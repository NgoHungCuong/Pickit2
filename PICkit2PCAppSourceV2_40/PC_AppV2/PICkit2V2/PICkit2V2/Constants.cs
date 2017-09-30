using System;
using System.Collections.Generic;
using System.Text;

namespace PICkit2V2
{
    public class Constants
    {
        // APPLICATION VERSION
        public const string AppVersion = "2.40.00";
        public const byte DevFileCompatLevel = 4;
        public const byte DevFileCompatLevelMin = 0;

        // min firmware version
        public const byte FWVerMajorReq = 2;
        public const byte FWVerMinorReq = 10;
        public const byte FWVerDotReq = 0;
        public const string FWFileName = "PK2V021000.hex";
    
        public const uint PACKET_SIZE = 65; // 64 + leading 0
        public const uint USB_REPORTLENGTH = 64;
        //
        public const byte BIT_MASK_0 = 0x01;
        public const byte BIT_MASK_1 = 0x02;
        public const byte BIT_MASK_2 = 0x04;
        public const byte BIT_MASK_3 = 0x08;
        public const byte BIT_MASK_4 = 0x10;
        public const byte BIT_MASK_5 = 0x20;
        public const byte BIT_MASK_6 = 0x40;
        public const byte BIT_MASK_7 = 0x80;
        //
        public const ushort MChipVendorID = 0x04D8;
        public const ushort Pk2DeviceID = 0x0033;
        //
        public const ushort ConfigRows = 2;
        public const ushort ConfigColumns = 4;
        public const ushort NumConfigMasks = 8;
        //
        public enum PICkit2USB
        {
            found,              // implies firmware version is good.
            notFound,
            writeError,
            readError,
            firmwareInvalid,
            bootloader
        };
        
        public enum PICkit2PWR
        {
            no_response,
            vdd_on,
            vdd_off,
            vdderror,
            vpperror,
            vddvpperrors,
            selfpowered,
            unpowered
        };
        
        public enum FileRead
        {
            success,
            failed,
            noconfig,
            largemem
        };
        
        public enum StatusColor
        {
            normal,
            green,
            yellow,
            red
        };
        
        public enum VddTargetSelect
        {
            auto,
            pickit2,
            target
        };
        
        public const float VddThresholdForSelfPoweredTarget = 2.3F;
        public const bool NoMessage = false;
        public const bool ShowMessage = true;
        public const bool UpdateMemoryDisplays = true;
        public const bool DontUpdateMemDisplays = false;
        public const bool EraseEE = true;
        public const bool WriteEE = false;
        
        //
        public const int UploadBufferSize = 128;
        public const int DownLoadBufferSize = 256;
        //
        public const byte READFWFLASH   = 1;
        public const byte WRITEFWFLASH  = 2;
        public const byte ERASEFWFLASH  = 3;
        public const byte READFWEEDATA  = 4;
        public const byte WRITEFWEEDATA = 5;
        public const byte RESETFWDEVICE  = 0xFF;
        //
        public const byte ENTER_BOOTLOADER      = 0x42;
        public const byte NO_OPERATION          = 0x5A;
        public const byte FIRMWARE_VERSION      = 0x76;
        public const byte SETVDD                = 0xA0;
        public const byte SETVPP                = 0xA1;
        public const byte READ_STATUS           = 0xA2;
        public const byte READ_VOLTAGES         = 0xA3;
        public const byte DOWNLOAD_SCRIPT       = 0xA4;
        public const byte RUN_SCRIPT            = 0xA5;
        public const byte EXECUTE_SCRIPT        = 0xA6;
        public const byte CLR_DOWNLOAD_BUFFER   = 0xA7;
        public const byte DOWNLOAD_DATA         = 0xA8;
        public const byte CLR_UPLOAD_BUFFER     = 0xA9;
        public const byte UPLOAD_DATA           = 0xAA;
        public const byte CLR_SCRIPT_BUFFER     = 0xAB;
        public const byte UPLOAD_DATA_NOLEN     = 0xAC;
        public const byte END_OF_BUFFER         = 0xAD;
        public const byte RESET                 = 0xAE;
        public const byte SCRIPT_BUFFER_CHKSUM  = 0xAF;
        public const byte SET_VOLTAGE_CALS      = 0xB0;
        public const byte WR_INTERNAL_EE        = 0xB1;
        public const byte RD_INTERNAL_EE        = 0xB2;
        public const byte ENTER_UART_MODE       = 0xB3;
        public const byte EXIT_UART_MODE        = 0xB4;        
        //
        public const byte _VDD_ON               = 0xFF;
        public const byte _VDD_OFF				= 0xFE;
        public const byte _VDD_GND_ON			= 0xFD;
        public const byte _VDD_GND_OFF			= 0xFC;
        public const byte _VPP_ON				= 0xFB;
        public const byte _VPP_OFF				= 0xFA;
        public const byte _VPP_PWM_ON			= 0xF9;
        public const byte _VPP_PWM_OFF			= 0xF8;
        public const byte _MCLR_GND_ON			= 0xF7;
        public const byte _MCLR_GND_OFF		    = 0xF6;
        public const byte _BUSY_LED_ON			= 0xF5;
        public const byte _BUSY_LED_OFF		    = 0xF4;
        public const byte _SET_ICSP_PINS		= 0xF3;
        public const byte _WRITE_BYTE_LITERAL	= 0xF2;
        public const byte _WRITE_BYTE_BUFFER    = 0xF1;
        public const byte _READ_BYTE_BUFFER     = 0xF0;
        public const byte _READ_BYTE  			= 0xEF;
        public const byte _WRITE_BITS_LITERAL	= 0xEE;
        public const byte _WRITE_BITS_BUFFER	= 0xED;
        public const byte _READ_BITS_BUFFER	    = 0xEC;
        public const byte _READ_BITS			= 0xEB;
        public const byte _SET_ICSP_SPEED       = 0xEA;
        public const byte _LOOP				    = 0xE9;
        public const byte _DELAY_LONG 			= 0xE8;
        public const byte _DELAY_SHORT			= 0xE7;
        public const byte _IF_EQ_GOTO    	    = 0xE6;
        public const byte _IF_GT_GOTO			= 0xE5;
        public const byte _GOTO_INDEX           = 0xE4;
        public const byte _EXIT_SCRIPT   	    = 0xE3;
        public const byte _PEEK_SFR 			= 0xE2;
        public const byte _POKE_SFR 			= 0xE1;

        public const byte _ICDSLAVE_RX          = 0xE0;
        public const byte _ICDSLAVE_TX_LIT      = 0xDF;
        public const byte _ICDSLAVE_TX_BUF      = 0xDE;
        public const byte _LOOPBUFFER           = 0xDD;
        public const byte _ICSP_STATES_BUFFER   = 0xDC;
        public const byte _POP_DOWNLOAD         = 0xDB;
        public const byte _COREINST18           = 0xDA;
        public const byte _COREINST24           = 0xD9;
        public const byte _NOP24                = 0xD8;
        public const byte _VISI24               = 0xD7;
        public const byte _RD2_BYTE_BUFFER      = 0xD6;
        public const byte _RD2_BITS_BUFFER      = 0xD5;
        public const byte _WRITE_BUFWORD_W      = 0xD4;
        public const byte _WRITE_BUFBYTE_W      = 0xD3;
        public const byte _CONST_WRITE_DL       = 0xD2;

        public const byte _WRITE_BITS_LIT_HLD   = 0xD1;
        public const byte _WRITE_BITS_BUF_HLD   = 0xD0;
        public const byte _SET_AUX              = 0xCF;
        public const byte _AUX_STATE_BUFFER     = 0xCE;
        public const byte _I2C_START            = 0xCD;
        public const byte _I2C_STOP             = 0xCC;
        public const byte _I2C_WR_BYTE_LIT      = 0xCB;
        public const byte _I2C_WR_BYTE_BUF      = 0xCA;
        public const byte _I2C_RD_BYTE_ACK      = 0xC9;
        public const byte _I2C_RD_BYTE_NACK     = 0xC8;
        public const byte _SPI_WR_BYTE_LIT      = 0xC7;
        public const byte _SPI_WR_BYTE_BUF      = 0xC6;
        public const byte _SPI_RD_BYTE_BUF      = 0xC5;
        public const byte _SPI_RDWR_BYTE_LIT    = 0xC4;
        public const byte _SPI_RDWR_BYTE_BUF    = 0xC3;        
        //
        public const int SEARCH_ALL_FAMILIES = 0xFFFFFF;
        //
        // Script Buffer Reserved Locations
        public const byte PROG_ENTRY        = 0;
        public const byte PROG_EXIT         = 1;
        public const byte RD_DEVID          = 2;
        public const byte PROGMEM_RD        = 3;
        public const byte ERASE_CHIP_PREP   = 4;
        public const byte PROGMEM_ADDRSET   = 5;
        public const byte PROGMEM_WR_PREP   = 6;
        public const byte PROGMEM_WR        = 7;
        public const byte EE_RD_PREP        = 8;
        public const byte EE_RD             = 9;
        public const byte EE_WR_PREP        = 10;
        public const byte EE_WR             = 11;
        public const byte CONFIG_RD_PREP    = 12;
        public const byte CONFIG_RD         = 13;
        public const byte CONFIG_WR_PREP    = 14;
        public const byte CONFIG_WR         = 15;
        public const byte USERID_RD_PREP    = 16;
        public const byte USERID_RD         = 17;
        public const byte USERID_WR_PREP    = 18;
        public const byte USERID_WR         = 19;
        public const byte OSSCAL_RD         = 20;
        public const byte OSSCAL_WR         = 21;
        public const byte ERASE_CHIP        = 22;
        public const byte ERASE_PROGMEM     = 23;
        public const byte ERASE_EE          = 24;
        //public const byte ERASE_CONFIG      = 25;
        public const byte ROW_ERASE         = 26;
        public const byte TESTMEM_RD        = 27;
        public const byte EEROW_ERASE       = 28;
        
        // OSCCAL valid mask in config masks
        public const int OSCCAL_MASK        = 7;
        
        // EEPROM config words
        public const int PROTOCOL_CFG       = 0;
        public const int ADR_MASK_CFG       = 1;
        public const int ADR_BITS_CFG       = 2;
        public const int CS_PINS_CFG        = 3;
        // EEPROM Protocols
        public const int I2C_BUS            = 1;
        public const int SPI_BUS            = 2;
        public const int MICROWIRE_BUS      = 3;
        public const bool READ_BIT          = true;
        public const bool WRITE_BIT         = false;
        
        // for user32.dll window flashing
        //Stop flashing. The system restores the window to its original state. 
        public const UInt32 FLASHW_STOP = 0;
        //Flash the window caption. 
        public const UInt32 FLASHW_CAPTION = 1;
        //Flash the taskbar button. 
        public const UInt32 FLASHW_TRAY = 2;
        //Flash both the window caption and taskbar button.
        //This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags. 
        public const UInt32 FLASHW_ALL = 3;
        //Flash continuously, until the FLASHW_STOP flag is set. 
        public const UInt32 FLASHW_TIMER = 4;
        //Flash continuously until the window comes to the foreground. 
        public const UInt32 FLASHW_TIMERNOFG = 12; 

        // PICkit 2 internal EEPROM Locations
        public const byte ADC_CAL_L         = 0x00;
        public const byte ADC_CAL_H         = 0x01;
        public const byte CPP_OFFSET        = 0x02;
        public const byte CPP_CAL           = 0x03;
        public const byte UNIT_ID           = 0xF0;  //through 0xFF
        
        /*

        public struct OVERLAPPED
        {
            public int Internal;
            public int InternalHigh;
            public int Offset;
            public int OffsetHigh;
            public int hEvent;
        };
         */
    }
}
