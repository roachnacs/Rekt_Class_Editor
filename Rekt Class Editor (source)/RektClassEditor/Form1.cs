using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace RektClassEditor
{
    public partial class Form1 : Form
    {
        Mem m = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        string Secondary;
        string PrimaryCamo;
        string Lethal;
        string Tactical;
        string Equipment;
        string LeathalByte;
        string TacticalByte;
        string EquipmentByte;
        string PrimaryAttachment;
        string AttachmentByte;
        string CamoByte;
        string Primary;
        string WeaponBytes;
        string WeaponBytes2;

        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("t5m.exe");
        }

        private void ClassSelector()
        {
            if (Class1.Checked == true)
            {
                Secondary = "04330F24";
                Primary = "04330F17";
                PrimaryCamo = "04330F1D"; 
                Lethal = "04330F1F";
                Tactical = "04330F30"; 
                Equipment = "04330F13";
                PrimaryAttachment = "04330F19";
            }
            if (Class2.Checked == true)
            {
                Secondary = "04330F47";
                Primary = "04330F3A";
                PrimaryCamo = "04330F40";
                Lethal = "04330F42";
                Tactical = "04330F53";
                Equipment = "04330F36";
                PrimaryAttachment = "04330F3C";
            }
            if (Class3.Checked == true)
            {
                Secondary = "04330F6A";
                Primary = "04330F5D";
                PrimaryCamo = "04330F63";
                Lethal = "04330F65";
                Tactical = "04330F76";
                Equipment = "04330F59";
                PrimaryAttachment = "04330F5F";
            }
            if (Class4.Checked == true)
            {
                Secondary = "04330F8D";
                Primary = "04330F80";
                PrimaryCamo = "04330F86";
                Lethal = "04330F88";
                Tactical = "04330F99";
                Equipment = "04330F7C";
                PrimaryAttachment = "04330F82";
            }
            if (Class5.Checked == true)
            {
                Secondary = "04330FB0";
                Primary = "04330FA3";
                PrimaryCamo = "04330FA9";
                Lethal = "04330FAB";
                Tactical = "04330FBC";
                Equipment = "04330F9F";
                PrimaryAttachment = "04330FA5";
            }
        }

        private void LethalBytes()
        {
            if (comboBox3.Text == "ASP")
                LeathalByte = "16";
            if (comboBox3.Text == "CZ75")
                LeathalByte = "32";
            if (comboBox3.Text == "M1911")
                LeathalByte = "48";
            if (comboBox3.Text == "Makarov")
                LeathalByte = "64";
            if (comboBox3.Text == "Python")
                LeathalByte = "80";
            if (comboBox3.Text == "MP5K")
                LeathalByte = "240";
            if (comboBox3.Text == "Skorpion")
                LeathalByte = "288";
            if (comboBox3.Text == "MAC11")
                LeathalByte = "224";
            if (comboBox3.Text == "AK74u")
                LeathalByte = "192";
            if (comboBox3.Text == "Uzi")
                LeathalByte = "320";
            if (comboBox3.Text == "PM63")
                LeathalByte = "272";
            if (comboBox3.Text == "MPL")
                LeathalByte = "256";
            if (comboBox3.Text == "Spectre")
                LeathalByte = "304";
            if (comboBox3.Text == "Kiparis")
                LeathalByte = "208";
            if (comboBox3.Text == "AK47")
                LeathalByte = "416";
            if (comboBox3.Text == "AUG")
                LeathalByte = "432";
            if (comboBox3.Text == "Commando")
                LeathalByte = "448";
            if (comboBox3.Text == "Enfield")
                LeathalByte = "464";
            if (comboBox3.Text == "Famas")
                LeathalByte = "480";
            if (comboBox3.Text == "FN FAL")
                LeathalByte = "496";
            if (comboBox3.Text == "G11")
                LeathalByte = "512";
            if (comboBox3.Text == "Galil")
                LeathalByte = "528";
            if (comboBox3.Text == "M14")
                LeathalByte = "544";
            if (comboBox3.Text == "M16")
                LeathalByte = "560";
            if (comboBox3.Text == "HK21")
                LeathalByte = "592";
            if (comboBox3.Text == "M60")
                LeathalByte = "608";
            if (comboBox3.Text == "RPK")
                LeathalByte = "624";
            if (comboBox3.Text == "Stoner63")
                LeathalByte = "640";
            if (comboBox3.Text == "Dragunov")
                LeathalByte = "672";
            if (comboBox3.Text == "L96A1")
                LeathalByte = "688";
            if (comboBox3.Text == "WA2000")
                LeathalByte = "720";
            if (comboBox3.Text == "PSG1")
                LeathalByte = "704";
            if (comboBox3.Text == "HS10")
                LeathalByte = "752";
            if (comboBox3.Text == "Stakeout")
                LeathalByte = "768";
            if (comboBox3.Text == "Olympia")
                LeathalByte = "784";
            if (comboBox3.Text == "SPAS-12")
                LeathalByte = "800";
            if (comboBox3.Text == "M72 LAW")
                LeathalByte = "848";
            if (comboBox3.Text == "RPG")
                LeathalByte = "864";
            if (comboBox3.Text == "Strela-3")
                LeathalByte = "880";
            if (comboBox3.Text == "China Lake")
                LeathalByte = "912";
            if (comboBox3.Text == "Ballistic Knife")
                LeathalByte = "992";
            if (comboBox3.Text == "Frag")
                LeathalByte = "1008";
            if (comboBox3.Text == "Semtex")
                LeathalByte = "1024";
            if (comboBox3.Text == "Tomahawk")
                LeathalByte = "1040";
            if (comboBox3.Text == "Willy Pete")
                LeathalByte = "1072";
            if (comboBox3.Text == "Nova Gas")
                LeathalByte = "1088";
            if (comboBox3.Text == "Flash Bang")
                LeathalByte = "1104";
            if (comboBox3.Text == "Concussion")
                LeathalByte = "1120";
            if (comboBox3.Text == "Decoy")
                LeathalByte = "1136";
            if (comboBox3.Text == "Claymore")
                LeathalByte = "1168";
            if (comboBox3.Text == "C4")
                LeathalByte = "1184";
            if (comboBox3.Text == "Jammer")
                LeathalByte = "1200";
            if (comboBox3.Text == "Tactical Insertion")
                LeathalByte = "1216";
            if (comboBox3.Text == "Camera Spike")
                LeathalByte = "1232";
            if (comboBox3.Text == "Motion Sensor")
                LeathalByte = "1248";
        }

        private void TacticalBytes()
        {
            if (comboBox4.Text == "ASP")
                TacticalByte = "16";
            if (comboBox4.Text == "CZ75")
                TacticalByte = "32";
            if (comboBox4.Text == "M1911")
                TacticalByte = "48";
            if (comboBox4.Text == "Makarov")
                TacticalByte = "64";
            if (comboBox4.Text == "Python")
                TacticalByte = "80";
            if (comboBox4.Text == "MP5K")
                TacticalByte = "240";
            if (comboBox4.Text == "Skorpion")
                TacticalByte = "288";
            if (comboBox4.Text == "MAC11")
                TacticalByte = "224";
            if (comboBox4.Text == "AK74u")
                TacticalByte = "192";
            if (comboBox4.Text == "Uzi")
                TacticalByte = "320";
            if (comboBox4.Text == "PM63")
                TacticalByte = "272";
            if (comboBox4.Text == "MPL")
                TacticalByte = "256";
            if (comboBox4.Text == "Spectre")
                TacticalByte = "304";
            if (comboBox4.Text == "Kiparis")
                TacticalByte = "208";
            if (comboBox4.Text == "AK47")
                TacticalByte = "416";
            if (comboBox4.Text == "AUG")
                TacticalByte = "432";
            if (comboBox4.Text == "Commando")
                TacticalByte = "448";
            if (comboBox4.Text == "Enfield")
                TacticalByte = "464";
            if (comboBox4.Text == "Famas")
                TacticalByte = "480";
            if (comboBox4.Text == "FN FAL")
                TacticalByte = "496";
            if (comboBox4.Text == "G11")
                TacticalByte = "512";
            if (comboBox4.Text == "Galil")
                TacticalByte = "528";
            if (comboBox4.Text == "M14")
                TacticalByte = "544";
            if (comboBox4.Text == "M16")
                TacticalByte = "560";
            if (comboBox4.Text == "HK21")
                TacticalByte = "592";
            if (comboBox4.Text == "M60")
                TacticalByte = "608";
            if (comboBox4.Text == "RPK")
                TacticalByte = "624";
            if (comboBox4.Text == "Stoner63")
                TacticalByte = "640";
            if (comboBox4.Text == "Dragunov")
                TacticalByte = "672";
            if (comboBox4.Text == "L96A1")
                TacticalByte = "688";
            if (comboBox4.Text == "WA2000")
                TacticalByte = "720";
            if (comboBox4.Text == "PSG1")
                TacticalByte = "704";
            if (comboBox4.Text == "HS10")
                TacticalByte = "752";
            if (comboBox4.Text == "Stakeout")
                TacticalByte = "768";
            if (comboBox4.Text == "Olympia")
                TacticalByte = "784";
            if (comboBox4.Text == "SPAS-12")
                TacticalByte = "800";
            if (comboBox4.Text == "M72 LAW")
                TacticalByte = "848";
            if (comboBox4.Text == "RPG")
                TacticalByte = "864";
            if (comboBox4.Text == "Strela-3")
                TacticalByte = "880";
            if (comboBox4.Text == "China Lake")
                TacticalByte = "912";
            if (comboBox4.Text == "Ballistic Knife")
                TacticalByte = "992";
            if (comboBox4.Text == "Frag")
                TacticalByte = "1008";
            if (comboBox4.Text == "Semtex")
                TacticalByte = "1024";
            if (comboBox4.Text == "Tomahawk")
                TacticalByte = "1040";
            if (comboBox4.Text == "Willy Pete")
                TacticalByte = "1072";
            if (comboBox4.Text == "Nova Gas")
                TacticalByte = "1088";
            if (comboBox4.Text == "Flash Bang")
                TacticalByte = "1104";
            if (comboBox4.Text == "Concussion")
                TacticalByte = "1120";
            if (comboBox4.Text == "Decoy")
                TacticalByte = "1136";
            if (comboBox4.Text == "Claymore")
                TacticalByte = "1168";
            if (comboBox4.Text == "C4")
                TacticalByte = "1184";
            if (comboBox4.Text == "Jammer")
                TacticalByte = "1200";
            if (comboBox4.Text == "Tactical Insertion")
                TacticalByte = "1216";
            if (comboBox4.Text == "Camera Spike")
                TacticalByte = "1232";
            if (comboBox4.Text == "Motion Sensor")
                TacticalByte = "1248";
        }

        private void EquipmentBytes()
        {
            if (comboBox5.Text == "ASP")
                EquipmentByte = "16";
            if (comboBox5.Text == "CZ75")
                EquipmentByte = "32";
            if (comboBox5.Text == "M1911")
                EquipmentByte = "48";
            if (comboBox5.Text == "Makarov")
                EquipmentByte = "64";
            if (comboBox5.Text == "Python")
                EquipmentByte = "80";
            if (comboBox5.Text == "MP5K")
                EquipmentByte = "240";
            if (comboBox5.Text == "Skorpion")
                EquipmentByte = "288";
            if (comboBox5.Text == "MAC11")
                EquipmentByte = "224";
            if (comboBox5.Text == "AK74u")
                EquipmentByte = "192";
            if (comboBox5.Text == "Uzi")
                EquipmentByte = "320";
            if (comboBox5.Text == "PM63")
                EquipmentByte = "272";
            if (comboBox5.Text == "MPL")
                EquipmentByte = "256";
            if (comboBox5.Text == "Spectre")
                EquipmentByte = "304";
            if (comboBox5.Text == "Kiparis")
                EquipmentByte = "208";
            if (comboBox5.Text == "AK47")
                EquipmentByte = "416";
            if (comboBox5.Text == "AUG")
                EquipmentByte = "432";
            if (comboBox5.Text == "Commando")
                EquipmentByte = "448";
            if (comboBox5.Text == "Enfield")
                EquipmentByte = "464";
            if (comboBox5.Text == "Famas")
                EquipmentByte = "480";
            if (comboBox5.Text == "FN FAL")
                EquipmentByte = "496";
            if (comboBox5.Text == "G11")
                EquipmentByte = "512";
            if (comboBox5.Text == "Galil")
                EquipmentByte = "528";
            if (comboBox5.Text == "M14")
                EquipmentByte = "544";
            if (comboBox5.Text == "M16")
                EquipmentByte = "560";
            if (comboBox5.Text == "HK21")
                EquipmentByte = "592";
            if (comboBox5.Text == "M60")
                EquipmentByte = "608";
            if (comboBox5.Text == "RPK")
                EquipmentByte = "624";
            if (comboBox5.Text == "Stoner63")
                EquipmentByte = "640";
            if (comboBox5.Text == "Dragunov")
                EquipmentByte = "672";
            if (comboBox5.Text == "L96A1")
                EquipmentByte = "688";
            if (comboBox5.Text == "WA2000")
                EquipmentByte = "720";
            if (comboBox5.Text == "PSG1")
                EquipmentByte = "704";
            if (comboBox5.Text == "HS10")
                EquipmentByte = "752";
            if (comboBox5.Text == "Stakeout")
                EquipmentByte = "768";
            if (comboBox5.Text == "Olympia")
                EquipmentByte = "784";
            if (comboBox5.Text == "SPAS-12")
                EquipmentByte = "800";
            if (comboBox5.Text == "M72 LAW")
                EquipmentByte = "848";
            if (comboBox5.Text == "RPG")
                EquipmentByte = "864";
            if (comboBox5.Text == "Strela-3")
                EquipmentByte = "880";
            if (comboBox5.Text == "China Lake")
                EquipmentByte = "912";
            if (comboBox5.Text == "Ballistic Knife")
                EquipmentByte = "992";
            if (comboBox5.Text == "Frag")
                EquipmentByte = "1008";
            if (comboBox5.Text == "Semtex")
                EquipmentByte = "1024";
            if (comboBox5.Text == "Tomahawk")
                EquipmentByte = "1040";
            if (comboBox5.Text == "Willy Pete")
                EquipmentByte = "1072";
            if (comboBox5.Text == "Nova Gas")
                EquipmentByte = "1088";
            if (comboBox5.Text == "Flash Bang")
                EquipmentByte = "1104";
            if (comboBox5.Text == "Concussion")
                EquipmentByte = "1120";
            if (comboBox5.Text == "Decoy")
                EquipmentByte = "1136";
            if (comboBox5.Text == "Claymore")
                EquipmentByte = "1168";
            if (comboBox5.Text == "C4")
                EquipmentByte = "1184";
            if (comboBox5.Text == "Jammer")
                EquipmentByte = "1200";
            if (comboBox5.Text == "Tactical Insertion")
                EquipmentByte = "1216";
            if (comboBox5.Text == "Camera Spike")
                EquipmentByte = "1232";
            if (comboBox5.Text == "Motion Sensor")
                EquipmentByte = "1248";
        }

        private void Weaponbytes()
        {
            if (comboBox1.Text == "ASP")
                WeaponBytes = "16";
            if (comboBox1.Text == "CZ75")
                WeaponBytes = "32";
            if (comboBox1.Text == "M1911")
                WeaponBytes = "48";
            if (comboBox1.Text == "Makarov")
                WeaponBytes = "64";
            if (comboBox1.Text == "Python")
                WeaponBytes = "80";
            if (comboBox1.Text == "MP5K")
                WeaponBytes = "240";
            if (comboBox1.Text == "Skorpion")
                WeaponBytes = "288";
            if (comboBox1.Text == "MAC11")
                WeaponBytes = "224";
            if (comboBox1.Text == "AK74u")
                WeaponBytes = "192";
            if (comboBox1.Text == "Uzi")
                WeaponBytes = "320";
            if (comboBox1.Text == "PM63")
                WeaponBytes = "272";
            if (comboBox1.Text == "MPL")
                WeaponBytes = "256";
            if (comboBox1.Text == "Spectre")
                WeaponBytes = "304";
            if (comboBox1.Text == "Kiparis")
                WeaponBytes = "208";
            if (comboBox1.Text == "AK47")
                WeaponBytes = "416";
            if (comboBox1.Text == "AUG")
                WeaponBytes = "432";
            if (comboBox1.Text == "Commando")
                WeaponBytes = "448";
            if (comboBox1.Text == "Enfield")
                WeaponBytes = "464";
            if (comboBox1.Text == "Famas")
                WeaponBytes = "480";
            if (comboBox1.Text == "FN FAL")
                WeaponBytes = "496";
            if (comboBox1.Text == "G11")
                WeaponBytes = "512";
            if (comboBox1.Text == "Galil")
                WeaponBytes = "528";
            if (comboBox1.Text == "M14")
                WeaponBytes = "544";
            if (comboBox1.Text == "M16")
                WeaponBytes = "560";
            if (comboBox1.Text == "HK21")
                WeaponBytes = "592";
            if (comboBox1.Text == "M60")
                WeaponBytes = "608";
            if (comboBox1.Text == "RPK")
                WeaponBytes = "624";
            if (comboBox1.Text == "Stoner63")
                WeaponBytes = "640";
            if (comboBox1.Text == "Dragunov")
                WeaponBytes = "672";
            if (comboBox1.Text == "L96A1")
                WeaponBytes = "688";
            if (comboBox1.Text == "WA2000")
                WeaponBytes = "720";
            if (comboBox1.Text == "PSG1")
                WeaponBytes = "704";
            if (comboBox1.Text == "HS10")
                WeaponBytes = "752";
            if (comboBox1.Text == "Stakeout")
                WeaponBytes = "768";
            if (comboBox1.Text == "Olympia")
                WeaponBytes = "784";
            if (comboBox1.Text == "SPAS-12")
                WeaponBytes = "800";
            if (comboBox1.Text == "M72 LAW")
                WeaponBytes = "848";
            if (comboBox1.Text == "RPG")
                WeaponBytes = "864";
            if (comboBox1.Text == "Strela-3")
                WeaponBytes = "880";
            if (comboBox1.Text == "China Lake")
                WeaponBytes = "912";
            if (comboBox1.Text == "Ballistic Knife")
                WeaponBytes = "992";
            if (comboBox1.Text == "Frag")
                WeaponBytes = "1008";
            if (comboBox1.Text == "Semtex")
                WeaponBytes = "1024";
            if (comboBox1.Text == "Tomahawk")
                WeaponBytes = "1040";
            if (comboBox1.Text == "Willy Pete")
                WeaponBytes = "1072";
            if (comboBox1.Text == "Nova Gas")
                WeaponBytes = "1088";
            if (comboBox1.Text == "Flash Bang")
                WeaponBytes = "1104";
            if (comboBox1.Text == "Concussion")
                WeaponBytes = "1120";
            if (comboBox1.Text == "Decoy")
                WeaponBytes = "1136";
            if (comboBox1.Text == "Claymore")
                WeaponBytes = "1168";
            if (comboBox1.Text == "C4")
                WeaponBytes = "1184";
            if (comboBox1.Text == "Jammer")
                WeaponBytes = "1200";
            if (comboBox1.Text == "Tactical Insertion")
                WeaponBytes = "1216";
            if (comboBox1.Text == "Camera Spike")
                WeaponBytes = "1232";
            if (comboBox1.Text == "Motion Sensor")
                WeaponBytes = "1248";

        }

        private void Weaponbytes2()
        {
            if (comboBox2.Text == "ASP")
                WeaponBytes2 = "16";
            if (comboBox2.Text == "CZ75")
                WeaponBytes2 = "32";
            if (comboBox2.Text == "M1911")
                WeaponBytes2 = "48";
            if (comboBox2.Text == "Makarov")
                WeaponBytes2 = "64";
            if (comboBox2.Text == "Python")
                WeaponBytes2 = "80";
            if (comboBox2.Text == "MP5K")
                WeaponBytes2 = "240";
            if (comboBox2.Text == "Skorpion")
                WeaponBytes2 = "288";
            if (comboBox2.Text == "MAC11")
                WeaponBytes2 = "224";
            if (comboBox2.Text == "AK74u")
                WeaponBytes2 = "192";
            if (comboBox2.Text == "Uzi")
                WeaponBytes2 = "320";
            if (comboBox2.Text == "PM63")
                WeaponBytes2 = "272";
            if (comboBox2.Text == "MPL")
                WeaponBytes2 = "256";
            if (comboBox2.Text == "Spectre")
                WeaponBytes2 = "304";
            if (comboBox2.Text == "Kiparis")
                WeaponBytes2 = "208";
            if (comboBox2.Text == "AK47")
                WeaponBytes2 = "416";
            if (comboBox2.Text == "AUG")
                WeaponBytes2 = "432";
            if (comboBox2.Text == "Commando")
                WeaponBytes2 = "448";
            if (comboBox2.Text == "Enfield")
                WeaponBytes2 = "464";
            if (comboBox2.Text == "Famas")
                WeaponBytes2 = "480";
            if (comboBox2.Text == "FN FAL")
                WeaponBytes2 = "496";
            if (comboBox2.Text == "G11")
                WeaponBytes2 = "512";
            if (comboBox2.Text == "Galil")
                WeaponBytes2 = "528";
            if (comboBox2.Text == "M14")
                WeaponBytes2 = "544";
            if (comboBox2.Text == "M16")
                WeaponBytes2 = "560";
            if (comboBox2.Text == "HK21")
                WeaponBytes2 = "592";
            if (comboBox2.Text == "M60")
                WeaponBytes2 = "608";
            if (comboBox2.Text == "RPK")
                WeaponBytes2 = "624";
            if (comboBox2.Text == "Stoner63")
                WeaponBytes2 = "640";
            if (comboBox2.Text == "Dragunov")
                WeaponBytes2 = "672";
            if (comboBox2.Text == "L96A1")
                WeaponBytes2 = "688";
            if (comboBox2.Text == "WA2000")
                WeaponBytes2 = "720";
            if (comboBox2.Text == "PSG1")
                WeaponBytes2 = "704";
            if (comboBox2.Text == "HS10")
                WeaponBytes2 = "752";
            if (comboBox2.Text == "Stakeout")
                WeaponBytes2 = "768";
            if (comboBox2.Text == "Olympia")
                WeaponBytes2 = "784";
            if (comboBox2.Text == "SPAS-12")
                WeaponBytes2 = "800";
            if (comboBox2.Text == "M72 LAW")
                WeaponBytes2 = "848";
            if (comboBox2.Text == "RPG")
                WeaponBytes2 = "864";
            if (comboBox2.Text == "Strela-3")
                WeaponBytes2 = "880";
            if (comboBox2.Text == "China Lake")
                WeaponBytes2 = "912";
            if (comboBox2.Text == "Ballistic Knife")
                WeaponBytes2 = "992";
            if (comboBox2.Text == "Frag")
                WeaponBytes2 = "1008";
            if (comboBox2.Text == "Semtex")
                WeaponBytes2 = "1024";
            if (comboBox2.Text == "Tomahawk")
                WeaponBytes2 = "1040";
            if (comboBox2.Text == "Willy Pete")
                WeaponBytes2 = "1072";
            if (comboBox2.Text == "Nova Gas")
                WeaponBytes2 = "1088";
            if (comboBox2.Text == "Flash Bang")
                WeaponBytes2 = "1104";
            if (comboBox2.Text == "Concussion")
                WeaponBytes2 = "1120";
            if (comboBox2.Text == "Decoy")
                WeaponBytes2 = "1136";
            if (comboBox2.Text == "Claymore")
                WeaponBytes2 = "1168";
            if (comboBox2.Text == "C4")
                WeaponBytes2 = "1184";
            if (comboBox2.Text == "Jammer")
                WeaponBytes2 = "1200";
            if (comboBox2.Text == "Tactical Insertion")
                WeaponBytes2 = "1216";
            if (comboBox2.Text == "Camera Spike")
                WeaponBytes2 = "1232";
            if (comboBox2.Text == "Motion Sensor")
                WeaponBytes2 = "1248";
        }

        private void PrimaryAttachmentBytes()
        {
            if (comboBox6.Text == "Extended Mag")
                AttachmentByte = "00 00 00 10";
            if (comboBox6.Text == "Dual Mag")
                AttachmentByte = "00 00 00 20";
            if (comboBox6.Text == "ACOG Sight")
                AttachmentByte = "00 00 30";
            if (comboBox6.Text == "Red Dot Sight")
                AttachmentByte = "00 00 40";
            if (comboBox6.Text == "Reflex Sight")
                AttachmentByte = "00 00 50";
            if (comboBox6.Text == "Infrared Scope")
                AttachmentByte = "00 00 80";
            if (comboBox6.Text == "Suppressor")
                AttachmentByte = "00 90";
            if (comboBox6.Text == "Masterkey")
                AttachmentByte = "60";
            if (comboBox6.Text == "Masterkey")
                AttachmentByte = "60";
            if (comboBox6.Text == "Flamethrower")
                AttachmentByte = "70";
            if (comboBox6.Text == "Grenade Launcher")
                AttachmentByte = "A0";
        }

        private void CamoBytes()
        {
            if (comboBox8.Text == "No Camo")
                CamoByte = "00";
            if (comboBox8.Text == "Dusty")
                CamoByte = "1A";
            if (comboBox8.Text == "Ice")
                CamoByte = "2A";
            if (comboBox8.Text == "Red")
                CamoByte = "3A";
            if (comboBox8.Text == "Olive")
                CamoByte = "4A";
            if (comboBox8.Text == "Nevada")
                CamoByte = "5A";
            if (comboBox8.Text == "Sahara")
                CamoByte = "6A";
            if (comboBox8.Text == "ERDL")
                CamoByte = "7A";
            if (comboBox8.Text == "Tiger")
                CamoByte = "8A";
            if (comboBox8.Text == "Berlin")
                CamoByte = "9A";
            if (comboBox8.Text == "Warsaw")
                CamoByte = "AA";
            if (comboBox8.Text == "Siberia")
                CamoByte = "BA";
            if (comboBox8.Text == "Yukon")
                CamoByte = "CA";
            if (comboBox8.Text == "Woodland")
                CamoByte = "DA";
            if (comboBox8.Text == "Flora")
                CamoByte = "EA";
            if (comboBox8.Text == "Gold")
                CamoByte = "FA";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.Weaponbytes();
            this.ClassSelector();
            m.WriteMemory("0x" + Primary, "int", "" + WeaponBytes);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Weaponbytes2();
            this.ClassSelector();
            m.WriteMemory("0x" + Secondary, "int", "" + WeaponBytes2);
        }

        // camos
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CamoBytes();
            this.ClassSelector();
            m.WriteMemory("0x" + PrimaryCamo, "byte", "" + CamoByte);
        }

        // attachments
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PrimaryAttachmentBytes();
            this.ClassSelector();
            m.WriteMemory("0x" + PrimaryAttachment, "bytes", "" + AttachmentByte);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LethalBytes();
            this.ClassSelector();
            m.WriteMemory("0x" + Lethal, "int", "" + LeathalByte);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TacticalBytes();
            this.ClassSelector();
            m.WriteMemory("0x" + Tactical, "int", "" + TacticalByte);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EquipmentBytes();
            this.ClassSelector();
            m.WriteMemory("0x" + Equipment, "int", "" + EquipmentByte);
        }
    }
}
