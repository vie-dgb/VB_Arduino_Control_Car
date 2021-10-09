/* Author: DGB
 * From: my lab WiH (more infor: IUH, DHDKTD14A)
 * this is my protocol used for Measurement & Control by Computer subject
 * email: dgb0728@gmail.com
 * github: github.com/giabao278 (give a star if you like my code)
 * just research & ignore my broken english
 * 
 * command_table.h
*/

#ifndef COMMAND_TABLE_H
#define COMMAND_TABLE_H

#include <string.h>
#include <stdlib.h>
#include "led_mode.h"
#include "stepper_mode.h"

/* declare enum command */
typedef enum
{
    /* led command */
    CMD_SLE,  // Set effect of led.
    CMD_SLT,  // Set led data but none effect
    CMD_SLS,  // Set timer of led
    CMD_SLR,  // Set led response or not response
    /* stepper command */
    CMD_SSR,  // Set stepper run or stop
    CMD_SPR,  // Set num step per round
    CMD_SRS,  // Set stepper run by step
    CMD_SRR,  // Set stepper run by round
    CMD_SSD,  // Set step direction
    CMD_SST,  // Set step time delay
    CMD_GSS,  // Get state of stepper run or stop
    CMD_GSD,  // Get direction of stepper
    CMD_HLP,  // Print all command information
    CMD_NON,  // Not found command
}command_e;

/* declare entry struct for search and call function */
typedef struct
{
    const char      *Name;
    const char      *Help;
    const command_e Command;
}command_entry_t;

/* declare command table */
const command_entry_t cmd_table[] = 
{   
    /* led command */
    {"SLE", "Set effect of led.", CMD_SLE},                         // SET LED EFFECT
    {"SLS", "Set led data but none effect.", CMD_SLS},              // SET LED SINGLE
	{"SLT", "Set timer of led.", CMD_SLT},                          // SET LED TIMER
    {"SLR", "Set led response.", CMD_SLR},                          // SET LED RESPONSE
    /* stepper command */
    {"SSR", "Set stepper run or stop.", CMD_SSR},                   // SET STEPPER RUN
    {"SPR", "Set num step per run.", CMD_SPR},                      // STEP PER ROUND
    {"SRS", "Set stepper run by step.", CMD_SRS},                   // SET RUN STEP
    {"SRR", "Set stepper run by round.", CMD_SRR},                  // SET RUN ROUND
    {"SSD", "Set step direction.", CMD_SSD},                        // SET STEP DIRECTION
    {"SST", "Set step time delay.", CMD_SST},                       // SET STEP TIMER
    {"GSS", "Get state of stepper run or stop.", CMD_GSS},          // GET STATE STEPPER
    {"GSD", "Get direction of stepper.", CMD_GSD},                  // GET STATE DIRECTION
    /* support command */
    {"HLP", "Print all command information.", CMD_HLP},             // HELP
    {NULL, "Not found command.", CMD_NON}                           // NOT FOUND COMMAND
};

/*------------------------Declare function------------------------*/
command_e command_search(char *pCmd);
void command_excute(char *pCmd, char *argv_1);


/*-----------------------function implement-----------------------*/

/* Search command in command table declare */
command_e command_search(char *pCmd)
{
    int cmdIndex = 0;
    while(cmd_table[cmdIndex].Command != CMD_NON)
    {
        if(strcmp(cmd_table[cmdIndex].Name,pCmd) == 0) {
            return cmd_table[cmdIndex].Command;
        }
        else {
            cmdIndex++;
        }
    }
    return CMD_NON;
}

/* excute command function call by my_protocol_decode function */
void command_excute(char *pCmd, char *argv_1)
{
    const command_e cmd_search = command_search(pCmd);
    switch (cmd_search)
    {
        case CMD_SLE:{  // SET LED EFFECT
            // Set effect of led
            int modeLED = atoi(argv_1);
            led_setMode(modeLED);
            break;
        }
        case CMD_SLS:{  // SET LED SINGLE
            // Set led data but none effect
            char sngLed = *argv_1;
            led_setSingle(sngLed);
            break;
        }
        case CMD_SLT:{  // SET LED TIMER
            // Set timer of led
            int timerLED = atoi(argv_1);
            led_setTimer(timerLED);
            break;
        }
        case CMD_SLR:{  // SET LED RESPONSE
            // Set led response or not response
            int repState = atoi(argv_1);
            led_reps(repState);
            break;
        }
        case CMD_SSR:{  // SET STEPPER RUN
            // Set stepper run or stop
            int _stepState = atoi(argv_1);
            stepper_Stop(_stepState);
            break;
        }
        case CMD_SPR:{  // STEP PER ROUND
            // Set num step per round
            int _step_perRound = atoi(argv_1);
            stepper_set_step_per_round(_step_perRound);
            break;
        }
        case CMD_SRS:{  // SET RUN STEP
            // Set stepper run by step
            int _stepLimit = atoi(argv_1);
            stepper_run_step(_stepLimit);
            break;
        }
        case CMD_SRR:{  // SET RUN ROUND
            // Set stepper run by round
            int _roundLimit = atoi(argv_1);
            stepper_run_round(_roundLimit);
            break;
        }
        case CMD_SSD:{  // SET STEP DIRECTION
            // Set step direction
            int _DirState = atoi(argv_1);
            stepper_SetDir(_DirState);
            break;
        }
        case CMD_SST:{  // SET STEP TIMER
            // Set step time delay
            int _DelayTime = atoi(argv_1);
            stepper_SetTimeDelay(_DelayTime);
            break;
        }
        case CMD_GSS:{  // GET STATE STEPPER
            // Get state of stepper run or stop
            stepper_respState();
            break;
        }
        case CMD_GSD:{  // GET STATE DIRECTION
            // Get direction of stepper
            stepper_respDir();
            break;
        }
        case CMD_HLP:{  // HELP
            // Print all command information
            int helpIndex = 0;
            Serial.println(" ");
            while(cmd_table[helpIndex].Command != CMD_NON)
            {
                Serial.print(cmd_table[helpIndex].Name);
                Serial.print(" : ");
                Serial.println(cmd_table[helpIndex].Help);
                helpIndex++;
            }
            break;
        }
        case CMD_NON:{  // NOT FOUND COMMAND
            // Not found command
            Serial.println(cmd_table[CMD_NON].Help);
            break;
        }
    }
}

#endif
