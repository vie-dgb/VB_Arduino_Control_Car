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

enum stepperMode_e{
    Step_IDLE,
    Step_RUN_STEP,
    Step_RUN_ROUND,
    Step_RUN_IFINITE,
};

stepperMode_e step_mode;
stepperMode_e lst_step_mode;

int stepper_step_cnt;
int stepper_step_round;

volatile int stepPin_arr[4] = {0};
volatile int stepDir;
volatile int stepState;
volatile uint32_t stepTimeOut;
volatile uint32_t stepTimeStamp;
volatile int stepCnt;

/* Half step array */
const bool step_excute_arr[16][4] =   { {1, 0, 0, 0},
                                        {1, 1, 0, 0},
                                        {0, 1, 0, 0},
                                        {0, 1, 1, 0},
                                        {0, 0, 1, 0},
                                        {0, 0, 1, 1},
                                        {0, 0, 0, 1},
                                        {1, 0, 0, 1} };

volatile int run_step_cnt;
volatile int run_step_limit;
volatile int step_per_round;
volatile int run_round_cnt;
volatile int run_round_limit;

/*------------------------Declare function------------------------*/
void stepper_init(int a, int b, int c, int d, uint32_t timeDelay);
void stepper_SetDir(int dir);
void stepper_SetTimeDelay(int dir);
void stepper_Stop(int StateStep);
void stepper_respState(void);
void stepper_respDir(void);
void stepper_set_step_per_round(int _step_per_round);
void stepper_run_step(int stepper_step);
void stepper_run_round(int stepper_round);
//void stepper_run_ifinite(void);
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
    stepCnt = 0;
    step_mode = Step_IDLE;
    lst_step_mode = Step_IDLE;
    step_per_round = 12;
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
    if(stepState==0)
    {
        step_mode = Step_IDLE;
    }
    else if(stepState==1)
    {
        step_mode = Step_RUN_IFINITE;
    }
    //stepper_respState();
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

/* set step per round of stepper */
void stepper_set_step_per_round(int _step_per_round)
{
    step_per_round = _step_per_round;
}

/* set stepper run step */
void stepper_run_step(int stepper_step)
{
    run_step_limit = stepper_step;
    step_mode = Step_RUN_STEP;
}

/* set stepper run round */
void stepper_run_round(int stepper_round)
{
    run_round_limit = stepper_round;
    step_mode = Step_RUN_ROUND;
}

/* set stepper run ifinite */
// void stepper_run_ifinite(void)
// {
//     step_mode = Step_RUN_ROUND;
// }

/* check case stepper */
void stepper_excute()
{
    /* full step */
    // switch(stepCnt)
    // {
    //   case 1:
    //      digitalWrite(stepPin_arr[0], 1);
    //      digitalWrite(stepPin_arr[1], 0);
    //      digitalWrite(stepPin_arr[2], 0);
    //      digitalWrite(stepPin_arr[3], 0);
    //      break;
    //   case 2:
    //      digitalWrite(stepPin_arr[1], 1);
    //      digitalWrite(stepPin_arr[0], 0);
    //      digitalWrite(stepPin_arr[2], 0);
    //      digitalWrite(stepPin_arr[3], 0);
    //      break;
    //   case 3:
    //      digitalWrite(stepPin_arr[2], 1);
    //      digitalWrite(stepPin_arr[1], 0);
    //      digitalWrite(stepPin_arr[0], 0);
    //      digitalWrite(stepPin_arr[3], 0);
    //      break;
    //   case 4:
    //      digitalWrite(stepPin_arr[3], 1);
    //      digitalWrite(stepPin_arr[2], 0);
    //      digitalWrite(stepPin_arr[1], 0);
    //      digitalWrite(stepPin_arr[0], 0);
    //      break;
    // }

    /* half step */
    digitalWrite(stepPin_arr[0], step_excute_arr[stepCnt][0]);
    digitalWrite(stepPin_arr[1], step_excute_arr[stepCnt][1]);
    digitalWrite(stepPin_arr[2], step_excute_arr[stepCnt][2]);
    digitalWrite(stepPin_arr[3], step_excute_arr[stepCnt][3]);

    if(stepDir==0)  stepCnt+=1;
    else            stepCnt-=1;
    if(stepCnt<=0) stepCnt=7;
    if(stepCnt>=8) stepCnt=0;
}

/* handle stepper function */
void stepper_handle()
{
    if(lst_step_mode!=step_mode)
    {
        run_step_cnt = 0;
        run_round_cnt = 0;
        lst_step_mode = step_mode;
        /* response state run or stop */
        if(step_mode == Step_IDLE)  stepState = 0;
        else                        stepState = 1;
        stepper_respState();
    }
    if(step_mode != Step_IDLE)
    {
        if(millis()-stepTimeStamp>=stepTimeOut)
        {
            switch(step_mode)
            {
                case Step_RUN_STEP:{
                    if(run_step_cnt < run_step_limit)
                    {
                        run_step_cnt += 1;
                        stepper_excute();
                    }
                    else
                    {
                        step_mode = Step_IDLE;
                        rep_state = 0;
                    }
                    break;
                }
                case Step_RUN_ROUND:{
                    if(run_round_cnt < (run_round_limit * step_per_round))
                    {
                        run_round_cnt += 1;
                        stepper_excute();
                    }
                    else
                    {
                        step_mode = Step_IDLE;
                        rep_state = 0;
                    }
                    break;
                }
                case Step_RUN_IFINITE:{
                    stepper_excute();
                    break;
                }
            }
            stepTimeStamp = millis();
        }
    }
}

#endif
