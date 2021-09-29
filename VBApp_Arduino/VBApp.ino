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

uint32_t timeLedLoop = 0;

/* main setup function */
void setup() {
    /* init my protocol */
    my_protocol_init(115200);
    /* init led */
    led_init();
    led_init_lcd();
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

    /* check my code delay? */
    if(millis()-timeLedLoop>=250)
    {
        digitalWrite(13,!digitalRead(13));
        timeLedLoop = millis();
    }
}
