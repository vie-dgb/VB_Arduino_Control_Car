/* Author: DGB
 * From: my lab WiH (more infor: IUH, DHDKTD14A)
 * this is my protocol used for Measurement & Control by Computer subject
 * email: dgb0728@gmail.com
 * github: github.com/giabao278 (give a star if you like my code)
 * just research & ignore my broken english
 * 
 * my_protocol.h
*/

#ifndef MY_PROTOCOL_H
#define MY_PROTOCOL_H

#include <Wire.h>
#include "command_table.h"

/* define header, max length frame */
#define MAX_LENGTH  255
#define START_BYTE  's'
#define STOP_BYTE   't'
#define ESC_BYTE    'e'

/* Data Package struct */
typedef struct tagDataPackage
{
    char       data[MAX_LENGTH];
    uint8_t    len;
}DataPackage, *pDataPackage;

/* Data Command encoded struct */
typedef struct tagCmdPack
{
    char       cmd[4];
    char       argv_1[10];
    uint8_t    argv_1_len;
}CmdPack, *pCmdPack;

/* State of receive data */
typedef enum
{
    STATE_IDLE,
    STATE_REVC,
}ProcoState;

/* Declare data */
DataPackage rxDataPack;
/* Data pack encoded */
CmdPack cmdData;

ProcoState rxState;
char lst_rx_byte;
uint8_t rxIndex;
bool rxFlagEnd;

/*------------------------Declare function------------------------*/
void my_protocol_init(int32_t baudRate);
void my_protocol_poll(void);
void my_protocol_decode(void);


/*-----------------------function implement-----------------------*/

/* init function */
void my_protocol_init(int32_t baudRate)
{
    Serial.begin(baudRate);
    rxState = STATE_IDLE;
}

/* function check for every loop */
void my_protocol_poll()
{
  char rx_byte = '\0';
  if(Serial.available())
  {
    rx_byte = Serial.read();
    switch(rxState)
    {
      case STATE_IDLE:{
        lst_rx_byte = '\0';
        rxIndex = 0;
        if(rx_byte==START_BYTE)
        {
            rxDataPack.data[rxIndex++]= START_BYTE;
            lst_rx_byte = rx_byte;
            rxState = STATE_REVC;
        }
        break;
      }
        
      case STATE_REVC:{
        if((rx_byte == STOP_BYTE)&&(lst_rx_byte != ESC_BYTE))
        {
            rxDataPack.data[rxIndex++] = STOP_BYTE;
            rxDataPack.len = rxIndex;
            rxDataPack.data[rxIndex] = '\0';
            rxState = STATE_IDLE;
            rxFlagEnd = true;
            break;
        }
        else if((rx_byte == START_BYTE)&&(lst_rx_byte != ESC_BYTE))
        {
            rxIndex = 0; //reset frame
            rxDataPack.data[rxIndex++] = rx_byte;
            lst_rx_byte = rx_byte;
            break;
        }
        else
        {
            rxDataPack.data[rxIndex++] = rx_byte;
            lst_rx_byte = rx_byte;
        }
        break;
      }
    }
  }
}

/* function check for every loop */
void my_protocol_decode()
{
  if(rxFlagEnd)
  {
    uint8_t decodeIndex = 1;
    uint8_t cmdIndex = 0;
    uint8_t argvIndex = 0;
    for(decodeIndex=1;decodeIndex<(rxDataPack.len-1);decodeIndex++)
    {
      if(rxDataPack.data[decodeIndex] == ESC_BYTE)
      {
          if(cmdIndex<3) cmdData.cmd[cmdIndex++] = rxDataPack.data[++decodeIndex];
          else
          {
              cmdData.argv_1[cmdIndex-3] = rxDataPack.data[++decodeIndex];
              cmdIndex++;
          }            
      }
      else
      {
          if(cmdIndex<3) cmdData.cmd[cmdIndex++] = rxDataPack.data[decodeIndex];
          else            
          {
              cmdData.argv_1[cmdIndex-3] = rxDataPack.data[decodeIndex];
              cmdIndex++;
          }
      }
    }
    cmdData.cmd[3] = '\0';
    cmdData.argv_1[cmdIndex-3] = '\0';
    cmdData.argv_1_len = cmdIndex - 3;
    command_excute(cmdData.cmd,cmdData.argv_1);
    
    /*--------------Debug serial print---------------*/
    //Serial.write(rxDataPack.data,rxDataPack.len);
    // Serial.flush();
    // Serial.write("CMD:");
    // Serial.write(cmdData.cmd,3);
    // Serial.write(" Argv:");
    // Serial.write(cmdData.argv_1,cmdData.argv_1_len);
    /* -----------------------------------------------*/

    rxFlagEnd = false;
  }
}

#endif
