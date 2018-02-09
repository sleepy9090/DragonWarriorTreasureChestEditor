using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2018+
 */
namespace DragonWarriorTreasureChestEditor
{
    class Backend
    {
        string path;

        public Backend(string gamePath)
        {
            path = gamePath;
        }

        public Dictionary<string, string> getDefaultMapLocations()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items.Add("00", "00h - Unknown");
            items.Add("01", "01h - World Map");
            items.Add("02", "02h - Charlock Castle");
            items.Add("03", "03h - Hauksness Ruins");
            items.Add("04", "04h - Tantegel Castle");
            items.Add("05", "05h - Tantegel Throne Room");
            items.Add("06", "06h - Dragonlord's Throne Room");
            items.Add("07", "07h - Kol");
            items.Add("08", "08h - Brecconary");
            items.Add("09", "09h - Cantlin");
            items.Add("0A", "0Ah - Garinham");
            items.Add("0B", "0Bh - Rimuldar");
            items.Add("0C", "0Ch - Sunlight Shrine");
            items.Add("0D", "0Dh - Rain Shrine");
            items.Add("0E", "0Eh - Rainbow Shrine");
            items.Add("0F", "0Fh - Dragonlord Cavern B1");
            items.Add("10", "10h - Dragonlord Cavern B2");
            items.Add("11", "11h - Dragonlord Cavern B3");
            items.Add("12", "12h - Dragonlord Cavern B4");
            items.Add("13", "13h - Dragonlord Cavern B5");
            items.Add("14", "14h - Dragonlord Cavern B6");
            items.Add("15", "15h - Rimuldar Passage");
            items.Add("16", "16h - Cave west of Tantegel B1");
            items.Add("17", "17h - Cave west of Tantegel B2");
            items.Add("18", "18h - Garin's Grave B1");

            items.Add("19", "19h - Garin's Grave B3");
            items.Add("1A", "1Ah - Garin's Grave B4");
            items.Add("1B", "1Bh - Garin's Grave B2");
            items.Add("1C", "1Ch - Erdrick's Cave B1");
            items.Add("1D", "1Dh - Erdrick's Cave B2");

            items.Add("1E", "1Eh - Unknown");
            items.Add("1F", "1Fh - Unknown");

            items.Add("20", "20h - Unknown");
            items.Add("21", "21h - Unknown");
            items.Add("22", "22h - Unknown");
            items.Add("23", "23h - Unknown");
            items.Add("24", "24h - Unknown");
            items.Add("25", "25h - Unknown");
            items.Add("26", "26h - Unknown");
            items.Add("27", "27h - Unknown");
            items.Add("28", "28h - Unknown");
            items.Add("29", "29h - Unknown");
            items.Add("2A", "2Ah - Unknown");
            items.Add("2B", "2Bh - Unknown");
            items.Add("2C", "2Ch - Unknown");
            items.Add("2D", "2Dh - Unknown");
            items.Add("2E", "2Eh - Unknown");
            items.Add("2F", "2Fh - Unknown");

            items.Add("30", "30h - Unknown");
            items.Add("31", "31h - Unknown");
            items.Add("32", "32h - Unknown");
            items.Add("33", "33h - Unknown");
            items.Add("34", "34h - Unknown");
            items.Add("35", "35h - Unknown");
            items.Add("36", "36h - Unknown");
            items.Add("37", "37h - Unknown");
            items.Add("38", "38h - Unknown");
            items.Add("39", "39h - Unknown");
            items.Add("3A", "3Ah - Unknown");
            items.Add("3B", "3Bh - Unknown");
            items.Add("3C", "3Ch - Unknown");
            items.Add("3D", "3Dh - Unknown");
            items.Add("3E", "3Eh - Unknown");
            items.Add("3F", "3Fh - Unknown");

            items.Add("40", "40h - Unknown");
            items.Add("41", "41h - Unknown");
            items.Add("42", "42h - Unknown");
            items.Add("43", "43h - Unknown");
            items.Add("44", "44h - Unknown");
            items.Add("45", "45h - Unknown");
            items.Add("46", "46h - Unknown");
            items.Add("47", "47h - Unknown");
            items.Add("48", "48h - Unknown");
            items.Add("49", "49h - Unknown");
            items.Add("4A", "4Ah - Unknown");
            items.Add("4B", "4Bh - Unknown");
            items.Add("4C", "4Ch - Unknown");
            items.Add("4D", "4Dh - Unknown");
            items.Add("4E", "4Eh - Unknown");
            items.Add("4F", "4Fh - Unknown");

            items.Add("50", "50h - Unknown");
            items.Add("51", "51h - Unknown");
            items.Add("52", "52h - Unknown");
            items.Add("53", "53h - Unknown");
            items.Add("54", "54h - Unknown");
            items.Add("55", "55h - Unknown");
            items.Add("56", "56h - Unknown");
            items.Add("57", "57h - Unknown");
            items.Add("58", "58h - Unknown");
            items.Add("59", "59h - Unknown");
            items.Add("5A", "5Ah - Unknown");
            items.Add("5B", "5Bh - Unknown");
            items.Add("5C", "5Ch - Unknown");
            items.Add("5D", "5Dh - Unknown");
            items.Add("5E", "5Eh - Unknown");
            items.Add("5F", "5Fh - Unknown");

            items.Add("60", "60h - Unknown");
            items.Add("61", "61h - Unknown");
            items.Add("62", "62h - Unknown");
            items.Add("63", "63h - Unknown");
            items.Add("64", "64h - Unknown");
            items.Add("65", "65h - Unknown");
            items.Add("66", "66h - Unknown");
            items.Add("67", "67h - Unknown");
            items.Add("68", "68h - Unknown");
            items.Add("69", "69h - Unknown");
            items.Add("6A", "6Ah - Unknown");
            items.Add("6B", "6Bh - Unknown");
            items.Add("6C", "6Ch - Unknown");
            items.Add("6D", "6Dh - Unknown");
            items.Add("6E", "6Eh - Unknown");
            items.Add("6F", "6Fh - Unknown");

            items.Add("70", "70h - Unknown");
            items.Add("71", "71h - Unknown");
            items.Add("72", "72h - Unknown");
            items.Add("73", "73h - Unknown");
            items.Add("74", "74h - Unknown");
            items.Add("75", "75h - Unknown");
            items.Add("76", "76h - Unknown");
            items.Add("77", "77h - Unknown");
            items.Add("78", "78h - Unknown");
            items.Add("79", "79h - Unknown");
            items.Add("7A", "7Ah - Unknown");
            items.Add("7B", "7Bh - Unknown");
            items.Add("7C", "7Ch - Unknown");
            items.Add("7D", "7Dh - Unknown");
            items.Add("7E", "7Eh - Unknown");
            items.Add("7F", "7Fh - Unknown");

            items.Add("80", "80h - Unknown");
            items.Add("81", "81h - Unknown");
            items.Add("82", "82h - Unknown");
            items.Add("83", "83h - Unknown");
            items.Add("84", "84h - Unknown");
            items.Add("85", "85h - Unknown");
            items.Add("86", "86h - Unknown");
            items.Add("87", "87h - Unknown");
            items.Add("88", "88h - Unknown");
            items.Add("89", "89h - Unknown");
            items.Add("8A", "8Ah - Unknown");
            items.Add("8B", "8Bh - Unknown");
            items.Add("8C", "8Ch - Unknown");
            items.Add("8D", "8Dh - Unknown");
            items.Add("8E", "8Eh - Unknown");
            items.Add("8F", "8Fh - Unknown");

            items.Add("90", "90h - Unknown");
            items.Add("91", "91h - Unknown");
            items.Add("92", "92h - Unknown");
            items.Add("93", "93h - Unknown");
            items.Add("94", "94h - Unknown");
            items.Add("95", "95h - Unknown");
            items.Add("96", "96h - Unknown");
            items.Add("97", "97h - Unknown");
            items.Add("98", "98h - Unknown");
            items.Add("99", "99h - Unknown");
            items.Add("9A", "9Ah - Unknown");
            items.Add("9B", "9Bh - Unknown");
            items.Add("9C", "9Ch - Unknown");
            items.Add("9D", "9Dh - Unknown");
            items.Add("9E", "9Eh - Unknown");
            items.Add("9F", "9Fh - Unknown");

            items.Add("A0", "A0h - Unknown");
            items.Add("A1", "A1h - Unknown");
            items.Add("A2", "A2h - Unknown");
            items.Add("A3", "A3h - Unknown");
            items.Add("A4", "A4h - Unknown");
            items.Add("A5", "A5h - Unknown");
            items.Add("A6", "A6h - Unknown");
            items.Add("A7", "A7h - Unknown");
            items.Add("A8", "A8h - Unknown");
            items.Add("A9", "A9h - Unknown");
            items.Add("AA", "AAh - Unknown");
            items.Add("AB", "ABh - Unknown");
            items.Add("AC", "ACh - Unknown");
            items.Add("AD", "ADh - Unknown");
            items.Add("AE", "AEh - Unknown");
            items.Add("AF", "AFh - Unknown");

            items.Add("B0", "B0h - Unknown");
            items.Add("B1", "B1h - Unknown");
            items.Add("B2", "B2h - Unknown");
            items.Add("B3", "B3h - Unknown");
            items.Add("B4", "B4h - Unknown");
            items.Add("B5", "B5h - Unknown");
            items.Add("B6", "B6h - Unknown");
            items.Add("B7", "B7h - Unknown");
            items.Add("B8", "B8h - Unknown");
            items.Add("B9", "B9h - Unknown");
            items.Add("BA", "BAh - Unknown");
            items.Add("BB", "BBh - Unknown");
            items.Add("BC", "BCh - Unknown");
            items.Add("BD", "BDh - Unknown");
            items.Add("BE", "BEh - Unknown");
            items.Add("BF", "BFh - Unknown");

            items.Add("C0", "C0h - Unknown");
            items.Add("C1", "C1h - Unknown");
            items.Add("C2", "C2h - Unknown");
            items.Add("C3", "C3h - Unknown");
            items.Add("C4", "C4h - Unknown");
            items.Add("C5", "C5h - Unknown");
            items.Add("C6", "C6h - Unknown");
            items.Add("C7", "C7h - Unknown");
            items.Add("C8", "C8h - Unknown");
            items.Add("C9", "C9h - Unknown");
            items.Add("CA", "CAh - Unknown");
            items.Add("CB", "CBh - Unknown");
            items.Add("CC", "CCh - Unknown");
            items.Add("CD", "CDh - Unknown");
            items.Add("CE", "CEh - Unknown");
            items.Add("CF", "CFh - Unknown");

            items.Add("D0", "D0h - Unknown");
            items.Add("D1", "D1h - Unknown");
            items.Add("D2", "D2h - Unknown");
            items.Add("D3", "D3h - Unknown");
            items.Add("D4", "D4h - Unknown");
            items.Add("D5", "D5h - Unknown");
            items.Add("D6", "D6h - Unknown");
            items.Add("D7", "D7h - Unknown");
            items.Add("D8", "D8h - Unknown");
            items.Add("D9", "D9h - Unknown");
            items.Add("DA", "DAh - Unknown");
            items.Add("DB", "DBh - Unknown");
            items.Add("DC", "DCh - Unknown");
            items.Add("DD", "DDh - Unknown");
            items.Add("DE", "DEh - Unknown");
            items.Add("DF", "DFh - Unknown");

            items.Add("E0", "E0h - Unknown");
            items.Add("E1", "E1h - Unknown");
            items.Add("E2", "E2h - Unknown");
            items.Add("E3", "E3h - Unknown");
            items.Add("E4", "E4h - Unknown");
            items.Add("E5", "E5h - Unknown");
            items.Add("E6", "E6h - Unknown");
            items.Add("E7", "E7h - Unknown");
            items.Add("E8", "E8h - Unknown");
            items.Add("E9", "E9h - Unknown");
            items.Add("EA", "EAh - Unknown");
            items.Add("EB", "EBh - Unknown");
            items.Add("EC", "ECh - Unknown");
            items.Add("ED", "EDh - Unknown");
            items.Add("EE", "EEh - Unknown");
            items.Add("EF", "EFh - Unknown");

            items.Add("F0", "F0h - Unknown");
            items.Add("F1", "F1h - Unknown");
            items.Add("F2", "F2h - Unknown");
            items.Add("F3", "F3h - Unknown");
            items.Add("F4", "F4h - Unknown");
            items.Add("F5", "F5h - Unknown");
            items.Add("F6", "F6h - Unknown");
            items.Add("F7", "F7h - Unknown");
            items.Add("F8", "F8h - Unknown");
            items.Add("F9", "F9h - Unknown");
            items.Add("FA", "FAh - Unknown");
            items.Add("FB", "FBh - Unknown");
            items.Add("FC", "FCh - Unknown");
            items.Add("FD", "FDh - Unknown");
            items.Add("FE", "FEh - Unknown");
            items.Add("FF", "FFh - Unknown");

            return items;
        }

        public Dictionary<string, string> getDefaultXYCs()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            for (int x = 0; x < 256; x++ )
            {
                string hexString = convertDecStringToHexString(x.ToString());
                items.Add(hexString.PadLeft(2, '0'), x.ToString().PadLeft(2, '0'));
            }

            return items;
        }

        public Dictionary<string, string> getDefaultChestContents()
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            items.Add("00", "00h - Unknown");
            items.Add("01", "01h - Rainbow Drop");
            items.Add("02", "02h - Herb");
            items.Add("03", "03h - Key");
            items.Add("04", "04h - Torch");
            items.Add("05", "05h - Fairy Water");
            items.Add("06", "06h - Wings");
            items.Add("07", "07h - Dragon's Wings");
            items.Add("08", "08h - Fairy Flute");
            items.Add("09", "09h - Fighter's Ring");
            items.Add("0A", "0Ah - Erdrick's Token");
            items.Add("0B", "0Bh - Gwaelin's Love");
            items.Add("0C", "0Ch - Cursed Belt");
            items.Add("0D", "0Dh - Silver Harp");
            items.Add("0E", "0Eh - Gold (~107)");
            items.Add("0F", "0Fh - Stones of Sunlight");
            items.Add("10", "10h - Staff of Rain");
            items.Add("11", "11h - Erdrick's Sword");
            items.Add("12", "12h - Gold (~10)");
            items.Add("13", "13h - Gold (~10)");
            items.Add("14", "14h - Gold (~10)");
            items.Add("15", "15h - High Gold (~600)");
            items.Add("16", "16h - 120 Gold");
            items.Add("17", "17h - Tablet");

            items.Add("18", "18h - Unknown");
            items.Add("19", "19h - Unknown");
            items.Add("1A", "1Ah - Unknown");
            items.Add("1B", "1Bh - Unknown");
            items.Add("1C", "1Ch - Unknown");
            items.Add("1D", "1Dh - Unknown");
            items.Add("1E", "1Eh - Unknown");
            items.Add("1F", "1Fh - Unknown");

            items.Add("20", "20h - Unknown");
            items.Add("21", "21h - Unknown");
            items.Add("22", "22h - Unknown");
            items.Add("23", "23h - Unknown");
            items.Add("24", "24h - Unknown");
            items.Add("25", "25h - Unknown");
            items.Add("26", "26h - Unknown");
            items.Add("27", "27h - Unknown");
            items.Add("28", "28h - Unknown");
            items.Add("29", "29h - Unknown");
            items.Add("2A", "2Ah - Unknown");
            items.Add("2B", "2Bh - Unknown");
            items.Add("2C", "2Ch - Unknown");
            items.Add("2D", "2Dh - Unknown");
            items.Add("2E", "2Eh - Unknown");
            items.Add("2F", "2Fh - Unknown");

            items.Add("30", "30h - Unknown");
            items.Add("31", "31h - Unknown");
            items.Add("32", "32h - Unknown");
            items.Add("33", "33h - Unknown");
            items.Add("34", "34h - Unknown");
            items.Add("35", "35h - Unknown");
            items.Add("36", "36h - Unknown");
            items.Add("37", "37h - Unknown");
            items.Add("38", "38h - Unknown");
            items.Add("39", "39h - Unknown");
            items.Add("3A", "3Ah - Unknown");
            items.Add("3B", "3Bh - Unknown");
            items.Add("3C", "3Ch - Unknown");
            items.Add("3D", "3Dh - Unknown");
            items.Add("3E", "3Eh - Unknown");
            items.Add("3F", "3Fh - Unknown");

            items.Add("40", "40h - Unknown");
            items.Add("41", "41h - Unknown");
            items.Add("42", "42h - Unknown");
            items.Add("43", "43h - Unknown");
            items.Add("44", "44h - Unknown");
            items.Add("45", "45h - Unknown");
            items.Add("46", "46h - Unknown");
            items.Add("47", "47h - Unknown");
            items.Add("48", "48h - Unknown");
            items.Add("49", "49h - Unknown");
            items.Add("4A", "4Ah - Unknown");
            items.Add("4B", "4Bh - Unknown");
            items.Add("4C", "4Ch - Unknown");
            items.Add("4D", "4Dh - Unknown");
            items.Add("4E", "4Eh - Unknown");
            items.Add("4F", "4Fh - Unknown");

            items.Add("50", "50h - Unknown");
            items.Add("51", "51h - Unknown");
            items.Add("52", "52h - Unknown");
            items.Add("53", "53h - Unknown");
            items.Add("54", "54h - Unknown");
            items.Add("55", "55h - Unknown");
            items.Add("56", "56h - Unknown");
            items.Add("57", "57h - Unknown");
            items.Add("58", "58h - Unknown");
            items.Add("59", "59h - Unknown");
            items.Add("5A", "5Ah - Unknown");
            items.Add("5B", "5Bh - Unknown");
            items.Add("5C", "5Ch - Unknown");
            items.Add("5D", "5Dh - Unknown");
            items.Add("5E", "5Eh - Unknown");
            items.Add("5F", "5Fh - Unknown");

            items.Add("60", "60h - Unknown");
            items.Add("61", "61h - Unknown");
            items.Add("62", "62h - Unknown");
            items.Add("63", "63h - Unknown");
            items.Add("64", "64h - Unknown");
            items.Add("65", "65h - Unknown");
            items.Add("66", "66h - Unknown");
            items.Add("67", "67h - Unknown");
            items.Add("68", "68h - Unknown");
            items.Add("69", "69h - Unknown");
            items.Add("6A", "6Ah - Unknown");
            items.Add("6B", "6Bh - Unknown");
            items.Add("6C", "6Ch - Unknown");
            items.Add("6D", "6Dh - Unknown");
            items.Add("6E", "6Eh - Unknown");
            items.Add("6F", "6Fh - Unknown");

            items.Add("70", "70h - Unknown");
            items.Add("71", "71h - Unknown");
            items.Add("72", "72h - Unknown");
            items.Add("73", "73h - Unknown");
            items.Add("74", "74h - Unknown");
            items.Add("75", "75h - Unknown");
            items.Add("76", "76h - Unknown");
            items.Add("77", "77h - Unknown");
            items.Add("78", "78h - Unknown");
            items.Add("79", "79h - Unknown");
            items.Add("7A", "7Ah - Unknown");
            items.Add("7B", "7Bh - Unknown");
            items.Add("7C", "7Ch - Unknown");
            items.Add("7D", "7Dh - Unknown");
            items.Add("7E", "7Eh - Unknown");
            items.Add("7F", "7Fh - Unknown");

            items.Add("80", "80h - Unknown");
            items.Add("81", "81h - Unknown");
            items.Add("82", "82h - Unknown");
            items.Add("83", "83h - Unknown");
            items.Add("84", "84h - Unknown");
            items.Add("85", "85h - Unknown");
            items.Add("86", "86h - Unknown");
            items.Add("87", "87h - Unknown");
            items.Add("88", "88h - Unknown");
            items.Add("89", "89h - Unknown");
            items.Add("8A", "8Ah - Unknown");
            items.Add("8B", "8Bh - Unknown");
            items.Add("8C", "8Ch - Unknown");
            items.Add("8D", "8Dh - Unknown");
            items.Add("8E", "8Eh - Unknown");
            items.Add("8F", "8Fh - Unknown");

            items.Add("90", "90h - Unknown");
            items.Add("91", "91h - Unknown");
            items.Add("92", "92h - Unknown");
            items.Add("93", "93h - Unknown");
            items.Add("94", "94h - Unknown");
            items.Add("95", "95h - Unknown");
            items.Add("96", "96h - Unknown");
            items.Add("97", "97h - Unknown");
            items.Add("98", "98h - Unknown");
            items.Add("99", "99h - Unknown");
            items.Add("9A", "9Ah - Unknown");
            items.Add("9B", "9Bh - Unknown");
            items.Add("9C", "9Ch - Unknown");
            items.Add("9D", "9Dh - Unknown");
            items.Add("9E", "9Eh - Unknown");
            items.Add("9F", "9Fh - Unknown");

            items.Add("A0", "A0h - Unknown");
            items.Add("A1", "A1h - Unknown");
            items.Add("A2", "A2h - Unknown");
            items.Add("A3", "A3h - Unknown");
            items.Add("A4", "A4h - Unknown");
            items.Add("A5", "A5h - Unknown");
            items.Add("A6", "A6h - Unknown");
            items.Add("A7", "A7h - Unknown");
            items.Add("A8", "A8h - Unknown");
            items.Add("A9", "A9h - Unknown");
            items.Add("AA", "AAh - Unknown");
            items.Add("AB", "ABh - Unknown");
            items.Add("AC", "ACh - Unknown");
            items.Add("AD", "ADh - Unknown");
            items.Add("AE", "AEh - Unknown");
            items.Add("AF", "AFh - Unknown");

            items.Add("B0", "B0h - Unknown");
            items.Add("B1", "B1h - Unknown");
            items.Add("B2", "B2h - Unknown");
            items.Add("B3", "B3h - Unknown");
            items.Add("B4", "B4h - Unknown");
            items.Add("B5", "B5h - Unknown");
            items.Add("B6", "B6h - Unknown");
            items.Add("B7", "B7h - Unknown");
            items.Add("B8", "B8h - Unknown");
            items.Add("B9", "B9h - Unknown");
            items.Add("BA", "BAh - Unknown");
            items.Add("BB", "BBh - Unknown");
            items.Add("BC", "BCh - Unknown");
            items.Add("BD", "BDh - Unknown");
            items.Add("BE", "BEh - Unknown");
            items.Add("BF", "BFh - Unknown");

            items.Add("C0", "C0h - Unknown");
            items.Add("C1", "C1h - Unknown");
            items.Add("C2", "C2h - Unknown");
            items.Add("C3", "C3h - Unknown");
            items.Add("C4", "C4h - Unknown");
            items.Add("C5", "C5h - Unknown");
            items.Add("C6", "C6h - Unknown");
            items.Add("C7", "C7h - Unknown");
            items.Add("C8", "C8h - Unknown");
            items.Add("C9", "C9h - Unknown");
            items.Add("CA", "CAh - Unknown");
            items.Add("CB", "CBh - Unknown");
            items.Add("CC", "CCh - Unknown");
            items.Add("CD", "CDh - Unknown");
            items.Add("CE", "CEh - Unknown");
            items.Add("CF", "CFh - Unknown");

            items.Add("D0", "D0h - Unknown");
            items.Add("D1", "D1h - Unknown");
            items.Add("D2", "D2h - Unknown");
            items.Add("D3", "D3h - Unknown");
            items.Add("D4", "D4h - Unknown");
            items.Add("D5", "D5h - Unknown");
            items.Add("D6", "D6h - Unknown");
            items.Add("D7", "D7h - Unknown");
            items.Add("D8", "D8h - Unknown");
            items.Add("D9", "D9h - Unknown");
            items.Add("DA", "DAh - Unknown");
            items.Add("DB", "DBh - Unknown");
            items.Add("DC", "DCh - Unknown");
            items.Add("DD", "DDh - Unknown");
            items.Add("DE", "DEh - Unknown");
            items.Add("DF", "DFh - Unknown");

            items.Add("E0", "E0h - Unknown");
            items.Add("E1", "E1h - Unknown");
            items.Add("E2", "E2h - Unknown");
            items.Add("E3", "E3h - Unknown");
            items.Add("E4", "E4h - Unknown");
            items.Add("E5", "E5h - Unknown");
            items.Add("E6", "E6h - Unknown");
            items.Add("E7", "E7h - Unknown");
            items.Add("E8", "E8h - Unknown");
            items.Add("E9", "E9h - Unknown");
            items.Add("EA", "EAh - Unknown");
            items.Add("EB", "EBh - Unknown");
            items.Add("EC", "ECh - Unknown");
            items.Add("ED", "EDh - Unknown");
            items.Add("EE", "EEh - Unknown");
            items.Add("EF", "EFh - Unknown");

            items.Add("F0", "F0h - Unknown");
            items.Add("F1", "F1h - Unknown");
            items.Add("F2", "F2h - Unknown");
            items.Add("F3", "F3h - Unknown");
            items.Add("F4", "F4h - Unknown");
            items.Add("F5", "F5h - Unknown");
            items.Add("F6", "F6h - Unknown");
            items.Add("F7", "F7h - Unknown");
            items.Add("F8", "F8h - Unknown");
            items.Add("F9", "F9h - Unknown");
            items.Add("FA", "FAh - Unknown");
            items.Add("FB", "FBh - Unknown");
            items.Add("FC", "FCh - Unknown");
            items.Add("FD", "FDh - Unknown");
            items.Add("FE", "FEh - Unknown");
            items.Add("FF", "FFh - Unknown");
            return items;
        }

        public bool setTreasureData(int offset, string hexValue)
        {
            return writeByteArrayToFile(this.path, offset, StringToByteArray(hexValue));
        }

        #region common methods
        private static string convertHexStringToDecStringFourChar(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 4)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 4);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    // char character = System.Convert.ToChar(decval);
                    ascii += decval;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private static string convertHexStringToDecStringTwoChar(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    // char character = System.Convert.ToChar(decval);
                    ascii += decval;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }

        private static string convertDecStringToHexString(String decString)
        {
            int value = Convert.ToInt32(decString);
            string hexValue = String.Format("{0:X}", value);

            return hexValue;
        }

        private string getHexStringFromFile(int startPoint, int length)
        {
            string hexString = "";
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read))
            {
                long offset = fileStream.Seek(startPoint, SeekOrigin.Begin);

                for (int x = 0; x < length; x++)
                {
                    hexString += fileStream.ReadByte().ToString("X2");
                }

            }

            return hexString;
        }

        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private bool writeByteArrayToFile(string fileName, int startPoint, byte[] byteArray)
        {
            bool result = false;
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    fs.Position = startPoint;
                    fs.Write(byteArray, 0, byteArray.Length);
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error writing file: {0}", ex);
                result = false;
            }

            return result;
        }

        public int getComboboxIndex(int offset)
        {
            string hexString = getHexStringFromFile(offset, 1);
            int index = 0;

            hexString = hexString.ToUpper();
            switch (hexString)
            {
                case "00":
                    index = 0x00;
                    break;
                case "01":
                    index = 0x01;
                    break;
                case "02":
                    index = 0x02;
                    break;
                case "03":
                    index = 0x03;
                    break;
                case "04":
                    index = 0x04;
                    break;
                case "05":
                    index = 0x05;
                    break;
                case "06":
                    index = 0x06;
                    break;
                case "07":
                    index = 0x07;
                    break;
                case "08":
                    index = 0x08;
                    break;
                case "09":
                    index = 0x09;
                    break;
                case "0A":
                    index = 0x0A;
                    break;
                case "0B":
                    index = 0x0B;
                    break;
                case "0C":
                    index = 0x0C;
                    break;
                case "0D":
                    index = 0x0D;
                    break;
                case "0E":
                    index = 0x0E;
                    break;
                case "0F":
                    index = 0x0F;
                    break;
                case "10":
                    index = 0x10;
                    break;
                case "11":
                    index = 0x11;
                    break;
                case "12":
                    index = 0x12;
                    break;
                case "13":
                    index = 0x13;
                    break;
                case "14":
                    index = 0x14;
                    break;
                case "15":
                    index = 0x15;
                    break;
                case "16":
                    index = 0x16;
                    break;
                case "17":
                    index = 0x17;
                    break;
                case "18":
                    index = 0x18;
                    break;
                case "19":
                    index = 0x19;
                    break;
                case "1A":
                    index = 0x1A;
                    break;
                case "1B":
                    index = 0x1B;
                    break;
                case "1C":
                    index = 0x1C;
                    break;
                case "1D":
                    index = 0x1D;
                    break;
                case "1E":
                    index = 0x1E;
                    break;
                case "1F":
                    index = 0x1F;
                    break;
                case "20":
                    index = 0x20;
                    break;
                case "21":
                    index = 0x21;
                    break;
                case "22":
                    index = 0x22;
                    break;
                case "23":
                    index = 0x23;
                    break;
                case "24":
                    index = 0x24;
                    break;
                case "25":
                    index = 0x25;
                    break;
                case "26":
                    index = 0x26;
                    break;
                case "27":
                    index = 0x27;
                    break;
                case "28":
                    index = 0x28;
                    break;
                case "29":
                    index = 0x29;
                    break;
                case "2A":
                    index = 0x2A;
                    break;
                case "2B":
                    index = 0x2B;
                    break;
                case "2C":
                    index = 0x2C;
                    break;
                case "2D":
                    index = 0x2D;
                    break;
                case "2E":
                    index = 0x2E;
                    break;
                case "2F":
                    index = 0x2F;
                    break;
                case "30":
                    index = 0x30;
                    break;
                case "31":
                    index = 0x31;
                    break;
                case "32":
                    index = 0x32;
                    break;
                case "33":
                    index = 0x33;
                    break;
                case "34":
                    index = 0x34;
                    break;
                case "35":
                    index = 0x35;
                    break;
                case "36":
                    index = 0x36;
                    break;
                case "37":
                    index = 0x37;
                    break;
                case "38":
                    index = 0x38;
                    break;
                case "39":
                    index = 0x39;
                    break;
                case "3A":
                    index = 0x3A;
                    break;
                case "3B":
                    index = 0x3B;
                    break;
                case "3C":
                    index = 0x3C;
                    break;
                case "3D":
                    index = 0x3D;
                    break;
                case "3E":
                    index = 0x3E;
                    break;
                case "3F":
                    index = 0x3F;
                    break;
                case "40":
                    index = 0x40;
                    break;
                case "41":
                    index = 0x41;
                    break;
                case "42":
                    index = 0x42;
                    break;
                case "43":
                    index = 0x43;
                    break;
                case "44":
                    index = 0x44;
                    break;
                case "45":
                    index = 0x45;
                    break;
                case "46":
                    index = 0x46;
                    break;
                case "47":
                    index = 0x47;
                    break;
                case "48":
                    index = 0x48;
                    break;
                case "49":
                    index = 0x49;
                    break;
                case "4A":
                    index = 0x4A;
                    break;
                case "4B":
                    index = 0x4B;
                    break;
                case "4C":
                    index = 0x4C;
                    break;
                case "4D":
                    index = 0x4D;
                    break;
                case "4E":
                    index = 0x4E;
                    break;
                case "4F":
                    index = 0x4F;
                    break;
                case "50":
                    index = 0x50;
                    break;
                case "51":
                    index = 0x51;
                    break;
                case "52":
                    index = 0x52;
                    break;
                case "53":
                    index = 0x53;
                    break;
                case "54":
                    index = 0x54;
                    break;
                case "55":
                    index = 0x55;
                    break;
                case "56":
                    index = 0x56;
                    break;
                case "57":
                    index = 0x57;
                    break;
                case "58":
                    index = 0x58;
                    break;
                case "59":
                    index = 0x59;
                    break;
                case "5A":
                    index = 0x5A;
                    break;
                case "5B":
                    index = 0x5B;
                    break;
                case "5C":
                    index = 0x5C;
                    break;
                case "5D":
                    index = 0x5D;
                    break;
                case "5E":
                    index = 0x5E;
                    break;
                case "5F":
                    index = 0x5F;
                    break;
                case "60":
                    index = 0x60;
                    break;
                case "61":
                    index = 0x61;
                    break;
                case "62":
                    index = 0x62;
                    break;
                case "63":
                    index = 0x63;
                    break;
                case "64":
                    index = 0x64;
                    break;
                case "65":
                    index = 0x65;
                    break;
                case "66":
                    index = 0x66;
                    break;
                case "67":
                    index = 0x67;
                    break;
                case "68":
                    index = 0x68;
                    break;
                case "69":
                    index = 0x69;
                    break;
                case "6A":
                    index = 0x6A;
                    break;
                case "6B":
                    index = 0x6B;
                    break;
                case "6C":
                    index = 0x6C;
                    break;
                case "6D":
                    index = 0x6D;
                    break;
                case "6E":
                    index = 0x6E;
                    break;
                case "6F":
                    index = 0x6F;
                    break;
                case "70":
                    index = 0x70;
                    break;
                case "71":
                    index = 0x71;
                    break;
                case "72":
                    index = 0x72;
                    break;
                case "73":
                    index = 0x73;
                    break;
                case "74":
                    index = 0x74;
                    break;
                case "75":
                    index = 0x75;
                    break;
                case "76":
                    index = 0x76;
                    break;
                case "77":
                    index = 0x77;
                    break;
                case "78":
                    index = 0x78;
                    break;
                case "79":
                    index = 0x79;
                    break;
                case "7A":
                    index = 0x7A;
                    break;
                case "7B":
                    index = 0x7B;
                    break;
                case "7C":
                    index = 0x7C;
                    break;
                case "7D":
                    index = 0x7D;
                    break;
                case "7E":
                    index = 0x7E;
                    break;
                case "7F":
                    index = 0x7F;
                    break;
                case "80":
                    index = 0x80;
                    break;
                case "81":
                    index = 0x81;
                    break;
                case "82":
                    index = 0x82;
                    break;
                case "83":
                    index = 0x83;
                    break;
                case "84":
                    index = 0x84;
                    break;
                case "85":
                    index = 0x85;
                    break;
                case "86":
                    index = 0x86;
                    break;
                case "87":
                    index = 0x87;
                    break;
                case "88":
                    index = 0x88;
                    break;
                case "89":
                    index = 0x89;
                    break;
                case "8A":
                    index = 0x8A;
                    break;
                case "8B":
                    index = 0x8B;
                    break;
                case "8C":
                    index = 0x8C;
                    break;
                case "8D":
                    index = 0x8D;
                    break;
                case "8E":
                    index = 0x8E;
                    break;
                case "8F":
                    index = 0x8F;
                    break;
                case "90":
                    index = 0x90;
                    break;
                case "91":
                    index = 0x91;
                    break;
                case "92":
                    index = 0x92;
                    break;
                case "93":
                    index = 0x93;
                    break;
                case "94":
                    index = 0x94;
                    break;
                case "95":
                    index = 0x95;
                    break;
                case "96":
                    index = 0x96;
                    break;
                case "97":
                    index = 0x97;
                    break;
                case "98":
                    index = 0x98;
                    break;
                case "99":
                    index = 0x99;
                    break;
                case "9A":
                    index = 0x9A;
                    break;
                case "9B":
                    index = 0x9B;
                    break;
                case "9C":
                    index = 0x9C;
                    break;
                case "9D":
                    index = 0x9D;
                    break;
                case "9E":
                    index = 0x9E;
                    break;
                case "9F":
                    index = 0x9F;
                    break;
                case "A0":
                    index = 0xA0;
                    break;
                case "A1":
                    index = 0xA1;
                    break;
                case "A2":
                    index = 0xA2;
                    break;
                case "A3":
                    index = 0xA3;
                    break;
                case "A4":
                    index = 0xA4;
                    break;
                case "A5":
                    index = 0xA5;
                    break;
                case "A6":
                    index = 0xA6;
                    break;
                case "A7":
                    index = 0xA7;
                    break;
                case "A8":
                    index = 0xA8;
                    break;
                case "A9":
                    index = 0xA9;
                    break;
                case "AA":
                    index = 0xAA;
                    break;
                case "AB":
                    index = 0xAB;
                    break;
                case "AC":
                    index = 0xAC;
                    break;
                case "AD":
                    index = 0xAD;
                    break;
                case "AE":
                    index = 0xAE;
                    break;
                case "AF":
                    index = 0xAF;
                    break;
                case "B0":
                    index = 0xB0;
                    break;
                case "B1":
                    index = 0xB1;
                    break;
                case "B2":
                    index = 0xB2;
                    break;
                case "B3":
                    index = 0xB3;
                    break;
                case "B4":
                    index = 0xB4;
                    break;
                case "B5":
                    index = 0xB5;
                    break;
                case "B6":
                    index = 0xB6;
                    break;
                case "B7":
                    index = 0xB7;
                    break;
                case "B8":
                    index = 0xB8;
                    break;
                case "B9":
                    index = 0xB9;
                    break;
                case "BA":
                    index = 0xBA;
                    break;
                case "BB":
                    index = 0xBB;
                    break;
                case "BC":
                    index = 0xBC;
                    break;
                case "BD":
                    index = 0xBD;
                    break;
                case "BE":
                    index = 0xBE;
                    break;
                case "BF":
                    index = 0xBF;
                    break;
                case "C0":
                    index = 0xC0;
                    break;
                case "C1":
                    index = 0xC1;
                    break;
                case "C2":
                    index = 0xC2;
                    break;
                case "C3":
                    index = 0xC3;
                    break;
                case "C4":
                    index = 0xC4;
                    break;
                case "C5":
                    index = 0xC5;
                    break;
                case "C6":
                    index = 0xC6;
                    break;
                case "C7":
                    index = 0xC7;
                    break;
                case "C8":
                    index = 0xC8;
                    break;
                case "C9":
                    index = 0xC9;
                    break;
                case "CA":
                    index = 0xCA;
                    break;
                case "CB":
                    index = 0xCB;
                    break;
                case "CC":
                    index = 0xCC;
                    break;
                case "CD":
                    index = 0xCD;
                    break;
                case "CE":
                    index = 0xCE;
                    break;
                case "CF":
                    index = 0xCF;
                    break;
                case "D0":
                    index = 0xD0;
                    break;
                case "D1":
                    index = 0xD1;
                    break;
                case "D2":
                    index = 0xD2;
                    break;
                case "D3":
                    index = 0xD3;
                    break;
                case "D4":
                    index = 0xD4;
                    break;
                case "D5":
                    index = 0xD5;
                    break;
                case "D6":
                    index = 0xD6;
                    break;
                case "D7":
                    index = 0xD7;
                    break;
                case "D8":
                    index = 0xD8;
                    break;
                case "D9":
                    index = 0xD9;
                    break;
                case "DA":
                    index = 0xDA;
                    break;
                case "DB":
                    index = 0xDB;
                    break;
                case "DC":
                    index = 0xDC;
                    break;
                case "DD":
                    index = 0xDD;
                    break;
                case "DE":
                    index = 0xDE;
                    break;
                case "DF":
                    index = 0xDF;
                    break;
                case "E0":
                    index = 0xE0;
                    break;
                case "E1":
                    index = 0xE1;
                    break;
                case "E2":
                    index = 0xE2;
                    break;
                case "E3":
                    index = 0xE3;
                    break;
                case "E4":
                    index = 0xE4;
                    break;
                case "E5":
                    index = 0xE5;
                    break;
                case "E6":
                    index = 0xE6;
                    break;
                case "E7":
                    index = 0xE7;
                    break;
                case "E8":
                    index = 0xE8;
                    break;
                case "E9":
                    index = 0xE9;
                    break;
                case "EA":
                    index = 0xEA;
                    break;
                case "EB":
                    index = 0xEB;
                    break;
                case "EC":
                    index = 0xEC;
                    break;
                case "ED":
                    index = 0xED;
                    break;
                case "EE":
                    index = 0xEE;
                    break;
                case "EF":
                    index = 0xEF;
                    break;
                case "F0":
                    index = 0xF0;
                    break;
                case "F1":
                    index = 0xF1;
                    break;
                case "F2":
                    index = 0xF2;
                    break;
                case "F3":
                    index = 0xF3;
                    break;
                case "F4":
                    index = 0xF4;
                    break;
                case "F5":
                    index = 0xF5;
                    break;
                case "F6":
                    index = 0xF6;
                    break;
                case "F7":
                    index = 0xF7;
                    break;
                case "F8":
                    index = 0xF8;
                    break;
                case "F9":
                    index = 0xF9;
                    break;
                case "FA":
                    index = 0xFA;
                    break;
                case "FB":
                    index = 0xFB;
                    break;
                case "FC":
                    index = 0xFC;
                    break;
                case "FD":
                    index = 0xFD;
                    break;
                case "FE":
                    index = 0xFE;
                    break;
                case "FF":
                    index = 0xFF;
                    break;
                default:
                    index = 0;
                    break;
            }

            return index;
        }
        #endregion
    }
}
