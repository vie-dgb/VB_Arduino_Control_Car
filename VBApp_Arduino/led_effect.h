/* Author: DGB
 * From: my lab WiH (more infor: IUH, DHDKTD14A)
 * this is my protocol used for Measurement & Control by Computer subject
 * email: dgb0728@gmail.com
 * github: github.com/giabao278 (give a star if you like my code)
 * just research & ignore my broken english
 * 
 * led_effect.h
*/

#ifndef LED_EFFECT_H
#define LED_EFFECT_H

static uint8_t  led_cnt_mode = 0;

void led_effect_clear_cnt(void);
uint8_t led_effect_1(uint8_t byte_effect);
uint8_t led_effect_2(uint8_t byte_effect);
uint8_t led_effect_3(uint8_t byte_effect);
uint8_t led_effect_4();
uint8_t led_effect_5();

void led_effect_clear_cnt()
{
    led_cnt_mode = 0;
}

uint8_t led_effect_1(uint8_t byte_effect)
{
  if(byte_effect == 0xff)   return 0x00;
  else                      return 0xff;
}

uint8_t led_effect_2(uint8_t byte_effect)
{
    if(led_cnt_mode>7)
    {
        led_cnt_mode = 0;
        return 0x00;
    }
    else
    {
        return byte_effect|(0x01<<(led_cnt_mode++));
    }
}

uint8_t led_effect_3(uint8_t byte_effect)
{
    if(led_cnt_mode>7)
    {
        led_cnt_mode = 0;
        return 0x00;
    }
    else
    {
        return byte_effect|(0x80>>(led_cnt_mode++));
    }
}

uint8_t led_effect_4()
{
    if(led_cnt_mode>7)
    {
        led_cnt_mode = 0;
        return 0x00;
    }
    else
    {
        return (0x01<<(led_cnt_mode++));
    }
}

uint8_t led_effect_5()
{
    if(led_cnt_mode>7)
    {
        led_cnt_mode = 0;
        return 0x00;
    }
    else
    {
        return (0x80>>(led_cnt_mode++));
    }
}

#endif
