/* Author: DGB
 * From: my lab WiH (more infor: IUH, DHDKTD14A)
 * this is my protocol used for Measurement & Control by Computer subject
 * email: dgb0728@gmail.com
 * github: github.com/giabao278 (give a star if you like my code)
 * just research & ignore my broken english
 * 
 * led_mode.h
*/

#ifndef LED_MODE_H
#define LED_MODE_H

#include <LiquidCrystal_I2C.h>
#include <Wire.h>
#include "led_effect.h"

#define proteus_simu_addr 0x20
#define lcd_addr 0x27

/* init led variables */
static LiquidCrystal_I2C lcd_print(proteus_simu_addr,16,4);
/* lcd custom char on led and off led */
uint8_t led_off[8]  = {0xff,0x00,0x00,0x00,0x00,0x00,0xff};
uint8_t led_on[8]  = {0xff,0xff,0xff,0xff,0xff,0xff,0xff};
/* led byte date variable */
uint8_t led_byte = 0x00;
/* time led variables */
static uint32_t led_timeOut = 300;
static uint32_t led_timeUpdate = 0;
/* response state */
volatile int rep_state;
/* led mode enum */
enum ledMode_e{
    mode_idle,
    mode_1,
    mode_2,
    mode_3,
    mode_4,
    mode_5,
};
/* led mode enum variables */
ledMode_e led_mode;
ledMode_e lst_led_mode;

/*------------------------Declare function------------------------*/
void byte2hex(uint8_t *_byte);
void led_init(void);
void led_init_lcd(void);
void led_setMode(int _led_mode);
void led_reps(int _rep_state);
void led_setTimer(int _timer);
void led_setSingle(char byteled);
void led_update(uint8_t ledByte);
void led_reps_excute(char rbyte);
void led_handle(void);


/*-----------------------function implement-----------------------*/

/* convert byte to hex and print to lcd */
void byte2hex(uint8_t *_byte)
{
    static char HexLookUp[] = "0123456789ABCDEF";  
    static char dataHex[3] = {0};
    dataHex[0] = HexLookUp[*_byte >> 4];
    dataHex[1] = HexLookUp[*_byte & 0x0F];
    lcd_print.print(dataHex);
}

/* init led pin and variables */
void led_init(void)
{
  pinMode(13, OUTPUT);

  led_mode = mode_idle;
  lst_led_mode = led_mode;
  rep_state = false;
  led_timeUpdate = millis();
}

/* init lcd */
void led_init_lcd()
{
  lcd_print.init();
  lcd_print.clear();
  lcd_print.backlight();
  lcd_print.home();
  lcd_print.createChar(0, led_off);
  lcd_print.createChar(1, led_on);

  lcd_print.setCursor(0,0);
  lcd_print.print("LED data: ");
  byte2hex(&led_byte);
  lcd_print.print(" hex");
}

/* set led effects function */
void led_setMode(int _led_mode)
{
  if(_led_mode==0)        led_mode = mode_idle;
  else if(_led_mode==1)   led_mode = mode_1;
  else if(_led_mode==2)   led_mode = mode_2;
  else if(_led_mode==3)   led_mode = mode_3;
  else if(_led_mode==4)   led_mode = mode_4;
  else if(_led_mode==5)   led_mode = mode_5;
}

/* set time led excute */
void led_setTimer(int _timer)
{
  led_timeOut = (uint32_t)_timer;
}

/* set response state, 0: not rep, 1: rep */
void led_reps(int _rep_state)
{
    rep_state = _rep_state;
}

/* set date led, not led mode */
void led_setSingle(char byteled)
{
  led_byte = byteled;
  led_update(led_byte);
  lcd_print.setCursor(0,0);
  lcd_print.print("LED data: ");
  byte2hex(&led_byte);
  lcd_print.print(" hex");
}

/* update led in lcd and led pin function */
void led_update(uint8_t ledByte)
{
    for(int i=0;i<8;i++)
    {
        lcd_print.setCursor(14-(2*i),1);
        lcd_print.write((ledByte>>i)&0x01);
    }
}

/* excute function of response state led */
void led_reps_excute(char rbyte)
{
    char reps_buff[7] = {'s', 'R', 'E', 'P', '\0', '\0', '\0'};

    if((rbyte == 's') || (rbyte == 't') || (rbyte == 'e'))
    {
      reps_buff[4] = 'e';
      reps_buff[5] = rbyte;
      reps_buff[6] = 't';
      Serial.write((const char *)reps_buff,7);
    }
    else
    {
      reps_buff[4] = rbyte;
      reps_buff[5] = 't';
      reps_buff[6] = '\0';
      Serial.write((const char *)reps_buff,6);
    }    
}

/* handle mode led function */
void led_handle()
{
  if(millis() - led_timeUpdate >= led_timeOut)
  {
    if(lst_led_mode!=led_mode)
    {
      led_effect_clear_cnt();
      lst_led_mode = led_mode;
      //if(led_mode==mode_idle)
      //{
      led_byte = 0x00;
      led_update(led_byte);
      //}
      if(led_mode==mode_idle)
      {
        lcd_print.setCursor(0,0);
        lcd_print.print("LED data: ");
        byte2hex(&led_byte);
        lcd_print.print(" hex");
      }
      else
      {
        lcd_print.setCursor(0,0);
        lcd_print.print("LED Mode: ");
        lcd_print.print(led_mode);
        lcd_print.print("     ");
      }
    }

    switch(led_mode)
    {
      case mode_idle:
        return;
        break;
      case mode_1:
        led_byte = led_effect_1(led_byte);
        break;
      case mode_2:
        led_byte = led_effect_2(led_byte);
        break;
      case mode_3:
        led_byte = led_effect_3(led_byte);
        break;
      case mode_4:
        led_byte = led_effect_4();
        break;
      case mode_5:
        led_byte = led_effect_5();
        break;
      default:
        break;
    }
    led_update(led_byte);
    if(rep_state)
    {
      byte abyte = (byte)led_byte;
      led_reps_excute(abyte);
    }
    led_timeUpdate = millis();
  }
}
#endif
