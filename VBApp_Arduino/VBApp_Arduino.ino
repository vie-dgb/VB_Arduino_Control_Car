/* Author: DGB
 * From: my lab WiH (more infor: IUH, DHDKTD14A)
 * this is my protocol used for Measurement & Control by Computer subject
 * email: dgb0728@gmail.com
 * github: github.com/giabao278 (give a star if you like my code)
 * just research & ignore my broken english
 * 
 * VBApp.ino
*/

#include <Wire.h>
#include "my_protocol.h"
#include "stepper_mode.h"

uint32_t timeLedLoop = 0;

/* main setup function */
void setup() {
    /* init my protocol */
    my_protocol_init(9600);
    /* init led */
    led_init();
    led_init_lcd();
    /* init stepper */
    stepper_init(4,5,6,7,300);

    timeLedLoop = millis();
}

/* main loop function */
void loop() {
    /* check data receive in every loop */
    my_protocol_poll();
    /* decode and exute command if done receive (rxFlagEnd is set) */
    my_protocol_decode();
    /* handle led mode */
    led_handle();
    /* handle step motor */
    stepper_handle();
    /* check my code delay? */
    if(millis()-timeLedLoop>=200)
    {
        digitalWrite(13,!digitalRead(13));
        timeLedLoop = millis();
    }
}
