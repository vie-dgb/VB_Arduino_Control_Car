/* Author: DGB
 * From: my lab WiH (more infor: IUH, DHDKTD14A)
 * this is my protocol used for Measurement & Control by Computer subject
 * email: dgb0728@gmail.com
 * github: github.com/giabao278 (give a star if you like my code)
 * just research & ignore my broken english
 * 
 * stepper_mode.h
*/

#ifndef STEPPER_MODE_H
#define STEPPER_MODE_H

#include <Wire.h>

volatile int stepPin_arr[4] = {0};
volatile int stepDir;
volatile int stepState;
volatile uint32_t stepTimeOut;
volatile uint32_t stepTimeStamp;
volatile int stepCnt;

/*------------------------Declare function------------------------*/
void stepper_init(int a, int b, int c, int d, uint32_t timeDelay);
void stepper_SetDir(int dir);
void stepper_SetTimeDelay(int dir);
void stepper_Stop(int StateStep);
void stepper_respState(void);
void stepper_respDir(void);
void stepper_excute(void);
void stepper_handle(void);


/*-----------------------function implement-----------------------*/

/* init function */
void stepper_init(int a, int b, int c, int d, uint32_t timeDelay)
{
    /* init pin mode */
    stepPin_arr[0] = a;
    stepPin_arr[1] = b;
    stepPin_arr[2] = c;
    stepPin_arr[3] = d;
    pinMode(a, OUTPUT);
    pinMode(b, OUTPUT);
    pinMode(c, OUTPUT);
    pinMode(d, OUTPUT);
    /* init time */
    stepTimeOut = timeDelay;    
    stepTimeStamp = millis();
    /* init state */
    stepState = 0;
    stepDir = 1;
    stepCnt = 1;
}

/* set stepper direction left or right function */
void stepper_SetDir(int dir)
{
    stepDir = dir;
    stepper_respDir();
}

/* set stepper run or stop function */
void stepper_Stop(int StateStep)
{
    stepState = StateStep;
    stepper_respState();
}

/* set timer delay for stepper function */
void stepper_SetTimeDelay(int dir)
{
    stepTimeOut = (uint32_t)dir;
}

/* response state stepper run or stop function */
void stepper_respState()
{
    char stateResp = stepState + 0x30;
    char resp_state_buff[7] = {'s', 'R', 'S', 'S', stateResp, 't'};
    Serial.write((const char *)resp_state_buff,6);
}

/* response direction stepper CW or CCW function */
void stepper_respDir()
{
    char DirResp = stepDir + 0x30;
    char resp_dir_buff[7] = {'s', 'R', 'S', 'D', DirResp, 't'};
    Serial.write((const char *)resp_dir_buff,6);
}

/* check case stepper */
void stepper_excute()
{
    switch(stepCnt)
    {
      case 1:
         digitalWrite(stepPin_arr[0], 1);
         digitalWrite(stepPin_arr[1], 0);
         digitalWrite(stepPin_arr[2], 0);
         digitalWrite(stepPin_arr[3], 0);
         break;
      case 2:
         digitalWrite(stepPin_arr[1], 1);
         digitalWrite(stepPin_arr[0], 0);
         digitalWrite(stepPin_arr[2], 0);
         digitalWrite(stepPin_arr[3], 0);
         break;
      case 3:
         digitalWrite(stepPin_arr[2], 1);
         digitalWrite(stepPin_arr[1], 0);
         digitalWrite(stepPin_arr[0], 0);
         digitalWrite(stepPin_arr[3], 0);
         break;
      case 4:
         digitalWrite(stepPin_arr[3], 1);
         digitalWrite(stepPin_arr[2], 0);
         digitalWrite(stepPin_arr[1], 0);
         digitalWrite(stepPin_arr[0], 0);
         break;
    }

    if(stepDir==0)  stepCnt+=1;
    else            stepCnt-=1;
    if(stepCnt<1) stepCnt=4;
    if(stepCnt>4) stepCnt=1;
}

/* handle stepper function */
void stepper_handle()
{
    if(millis()-stepTimeStamp>=stepTimeOut)
    {
        if(stepState==1)
        {
            stepper_excute();
            stepTimeStamp = millis();
        }
    }
}

#endif
