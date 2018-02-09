using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 2018+
 */
namespace DragonWarriorTreasureChestEditor
{
    public partial class FormMain : Form
    {
        string path;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadDefaultComboBoxesData();
            enableDisableFormControls(false);
        }

        private void buttonOpenRom_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                textBoxFilename.Text = path;

                loadRom();
            }
        }

        private void loadRom()
        {
            getROMData();
            enableDisableFormControls(true);
        }

        private void getROMData()
        {
            Backend backend = new Backend(path);

            getComboBoxMapIndex(backend);
            getComboBoxXCIndex(backend);
            getComboBoxXYIndex(backend);
            getComboBoxChestContentsIndex(backend);
        }

        private void enableDisableFormControls(bool isEnabled)
        {
            updateROMToolStripMenuItem.Enabled = isEnabled;
            buttonUpdateChests.Enabled = isEnabled;
            groupBox1.Enabled = isEnabled;
        }

        private void loadDefaultComboBoxesData()
        {
            Backend backend = new Backend(path);

            loadDefaultMapData(backend);
            loadDefaultXCData(backend);
            loadDefaultYCData(backend);
            loadDefaultChestContentData(backend);
        }

        private void loadDefaultMapData(Backend backend)
        {
            Dictionary<string, string> mapLocations = backend.getDefaultMapLocations();

            var mapComboBoxes = new[]
            {
                 comboBox1, comboBox5, comboBox9, comboBox13, comboBox17, comboBox21, comboBox25, comboBox29, comboBox33, comboBox37,
                 comboBox41, comboBox45, comboBox49, comboBox53, comboBox57, comboBox61, comboBox65, comboBox69, comboBox73, comboBox77,
                 comboBox81, comboBox85, comboBox89, comboBox93, comboBox97, comboBox101, comboBox105, comboBox109, comboBox113, comboBox117,
                 comboBox121
            };

            foreach(var mapComboBox in mapComboBoxes)
            {
                mapComboBox.DataSource = new BindingSource(mapLocations, null);
                mapComboBox.DisplayMember = "Value";
                mapComboBox.ValueMember = "Key";
            }
        }

        private void loadDefaultXCData(Backend backend)
        {
            Dictionary<string, string> xcs = backend.getDefaultXYCs();

            var xComboBoxes = new[]
            {
                 comboBox2, comboBox6, comboBox10, comboBox14, comboBox18, comboBox22, comboBox26, comboBox30, comboBox34, comboBox38,
                 comboBox42, comboBox46, comboBox50, comboBox54, comboBox58, comboBox62, comboBox66, comboBox70, comboBox74, comboBox78,
                 comboBox82, comboBox86, comboBox90, comboBox94, comboBox98, comboBox102, comboBox106, comboBox110, comboBox114, comboBox118,
                 comboBox122
            };

            foreach (var xComboBox in xComboBoxes)
            {
                xComboBox.DataSource = new BindingSource(xcs, null);
                xComboBox.DisplayMember = "Value";
                xComboBox.ValueMember = "Key";
            }
        }

        private void loadDefaultYCData(Backend backend)
        {
            Dictionary<string, string> xys = backend.getDefaultXYCs();

            var yComboBoxes = new[]
            {
                 comboBox3, comboBox7, comboBox11, comboBox15, comboBox19, comboBox23, comboBox27, comboBox31, comboBox35, comboBox39,
                 comboBox43, comboBox47, comboBox51, comboBox55, comboBox59, comboBox63, comboBox67, comboBox71, comboBox75, comboBox79,
                 comboBox83, comboBox87, comboBox91, comboBox95, comboBox99, comboBox103, comboBox107, comboBox111, comboBox115, comboBox119,
                 comboBox123
            };

            foreach (var yComboBox in yComboBoxes)
            {
                yComboBox.DataSource = new BindingSource(xys, null);
                yComboBox.DisplayMember = "Value";
                yComboBox.ValueMember = "Key";
            }
        }

        private void loadDefaultChestContentData(Backend backend)
        {
            Dictionary<string, string> xys = backend.getDefaultChestContents();

            var chestContentsComboBoxes = new[]
            {
                 comboBox4, comboBox8, comboBox12, comboBox16, comboBox20, comboBox24, comboBox28, comboBox32, comboBox36, comboBox40,
                 comboBox44, comboBox48, comboBox52, comboBox56, comboBox60, comboBox64, comboBox68, comboBox72, comboBox76, comboBox80,
                 comboBox84, comboBox88, comboBox92, comboBox96, comboBox100, comboBox104, comboBox108, comboBox112, comboBox116, comboBox120,
                 comboBox124
            };

            foreach (var chestContentComboBox in chestContentsComboBoxes)
            {
                chestContentComboBox.DataSource = new BindingSource(xys, null);
                chestContentComboBox.DisplayMember = "Value";
                chestContentComboBox.ValueMember = "Key";
            }
        }

        private void getComboBoxMapIndex(Backend backend)
        {
            int offset = 0x5DDD;
            comboBox1.SelectedIndex = backend.getComboboxIndex(offset);
            comboBox5.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox9.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox13.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox17.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox21.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox25.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox29.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox33.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox37.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox41.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox45.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox49.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox53.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox57.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox61.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox65.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox69.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox73.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox77.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox81.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox85.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox89.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox93.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox97.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox101.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox105.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox109.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox113.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox117.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox121.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
        }

        private void getComboBoxXCIndex(Backend backend)
        {
            int offset = 0x5DDE;
            comboBox2.SelectedIndex = backend.getComboboxIndex(offset);
            comboBox6.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox10.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox14.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox18.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox22.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox26.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox30.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox34.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox38.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox42.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox46.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox50.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox54.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox58.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox62.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox66.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox70.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox74.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox78.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox82.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox86.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox90.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox94.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox98.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox102.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox106.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox110.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox114.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox118.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox122.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
        }

        private void getComboBoxXYIndex(Backend backend)
        {
            int offset = 0x5DDF;
            comboBox3.SelectedIndex = backend.getComboboxIndex(offset);
            comboBox7.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox11.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox15.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox19.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox23.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox27.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox31.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox35.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox39.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox43.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox47.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox51.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox55.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox59.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox63.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox67.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox71.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox75.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox79.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox83.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox87.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox91.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox95.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox99.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox103.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox107.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox111.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox115.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox119.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox123.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
        }

        private void getComboBoxChestContentsIndex(Backend backend)
        {
            int offset = 0x5DE0;
            comboBox4.SelectedIndex = backend.getComboboxIndex(offset);
            comboBox8.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox12.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox16.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox20.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox24.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox28.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox32.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox36.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox40.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox44.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox48.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox52.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox56.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox60.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox64.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox68.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox72.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox76.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox80.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox84.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox88.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox92.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox96.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox100.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox104.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox108.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox112.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox116.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox120.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
            comboBox124.SelectedIndex = backend.getComboboxIndex(offset += 0x4);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonOpenRom_Click(sender, e);
        }

        private void buttonUpdateChests_Click(object sender, EventArgs e)
        {
            Backend backend = new Backend(path);

            int offset = 0x5DDD;

            bool result1 = backend.setTreasureData(offset, comboBox1.SelectedValue.ToString());
            bool result2 = backend.setTreasureData(offset += 1, comboBox2.SelectedValue.ToString());
            bool result3 = backend.setTreasureData(offset += 1, comboBox3.SelectedValue.ToString());
            bool result4 = backend.setTreasureData(offset += 1, comboBox4.SelectedValue.ToString());
            bool result5 = backend.setTreasureData(offset += 1, comboBox5.SelectedValue.ToString());
            bool result6 = backend.setTreasureData(offset += 1, comboBox6.SelectedValue.ToString());
            bool result7 = backend.setTreasureData(offset += 1, comboBox7.SelectedValue.ToString());
            bool result8 = backend.setTreasureData(offset += 1, comboBox8.SelectedValue.ToString());
            bool result9 = backend.setTreasureData(offset += 1, comboBox9.SelectedValue.ToString());
            bool result10 = backend.setTreasureData(offset += 1, comboBox10.SelectedValue.ToString());

            bool result11 = backend.setTreasureData(offset += 1, comboBox11.SelectedValue.ToString());
            bool result12 = backend.setTreasureData(offset += 1, comboBox12.SelectedValue.ToString());
            bool result13 = backend.setTreasureData(offset += 1, comboBox13.SelectedValue.ToString());
            bool result14 = backend.setTreasureData(offset += 1, comboBox14.SelectedValue.ToString());
            bool result15 = backend.setTreasureData(offset += 1, comboBox15.SelectedValue.ToString());
            bool result16 = backend.setTreasureData(offset += 1, comboBox16.SelectedValue.ToString());
            bool result17 = backend.setTreasureData(offset += 1, comboBox17.SelectedValue.ToString());
            bool result18 = backend.setTreasureData(offset += 1, comboBox18.SelectedValue.ToString());
            bool result19 = backend.setTreasureData(offset += 1, comboBox19.SelectedValue.ToString());
            bool result20 = backend.setTreasureData(offset += 1, comboBox20.SelectedValue.ToString());

            bool result21 = backend.setTreasureData(offset += 1, comboBox21.SelectedValue.ToString());
            bool result22 = backend.setTreasureData(offset += 1, comboBox22.SelectedValue.ToString());
            bool result23 = backend.setTreasureData(offset += 1, comboBox23.SelectedValue.ToString());
            bool result24 = backend.setTreasureData(offset += 1, comboBox24.SelectedValue.ToString());
            bool result25 = backend.setTreasureData(offset += 1, comboBox25.SelectedValue.ToString());
            bool result26 = backend.setTreasureData(offset += 1, comboBox26.SelectedValue.ToString());
            bool result27 = backend.setTreasureData(offset += 1, comboBox27.SelectedValue.ToString());
            bool result28 = backend.setTreasureData(offset += 1, comboBox28.SelectedValue.ToString());
            bool result29 = backend.setTreasureData(offset += 1, comboBox29.SelectedValue.ToString());
            bool result30 = backend.setTreasureData(offset += 1, comboBox30.SelectedValue.ToString());

            bool result31 = backend.setTreasureData(offset += 1, comboBox31.SelectedValue.ToString());
            bool result32 = backend.setTreasureData(offset += 1, comboBox32.SelectedValue.ToString());
            bool result33 = backend.setTreasureData(offset += 1, comboBox33.SelectedValue.ToString());
            bool result34 = backend.setTreasureData(offset += 1, comboBox34.SelectedValue.ToString());
            bool result35 = backend.setTreasureData(offset += 1, comboBox35.SelectedValue.ToString());
            bool result36 = backend.setTreasureData(offset += 1, comboBox36.SelectedValue.ToString());
            bool result37 = backend.setTreasureData(offset += 1, comboBox37.SelectedValue.ToString());
            bool result38 = backend.setTreasureData(offset += 1, comboBox38.SelectedValue.ToString());
            bool result39 = backend.setTreasureData(offset += 1, comboBox39.SelectedValue.ToString());
            bool result40 = backend.setTreasureData(offset += 1, comboBox40.SelectedValue.ToString());

            bool result41 = backend.setTreasureData(offset += 1, comboBox41.SelectedValue.ToString());
            bool result42 = backend.setTreasureData(offset += 1, comboBox42.SelectedValue.ToString());
            bool result43 = backend.setTreasureData(offset += 1, comboBox43.SelectedValue.ToString());
            bool result44 = backend.setTreasureData(offset += 1, comboBox44.SelectedValue.ToString());
            bool result45 = backend.setTreasureData(offset += 1, comboBox45.SelectedValue.ToString());
            bool result46 = backend.setTreasureData(offset += 1, comboBox46.SelectedValue.ToString());
            bool result47 = backend.setTreasureData(offset += 1, comboBox47.SelectedValue.ToString());
            bool result48 = backend.setTreasureData(offset += 1, comboBox48.SelectedValue.ToString());
            bool result49 = backend.setTreasureData(offset += 1, comboBox49.SelectedValue.ToString());
            bool result50 = backend.setTreasureData(offset += 1, comboBox50.SelectedValue.ToString());

            bool result51 = backend.setTreasureData(offset += 1, comboBox51.SelectedValue.ToString());
            bool result52 = backend.setTreasureData(offset += 1, comboBox52.SelectedValue.ToString());
            bool result53 = backend.setTreasureData(offset += 1, comboBox53.SelectedValue.ToString());
            bool result54 = backend.setTreasureData(offset += 1, comboBox54.SelectedValue.ToString());
            bool result55 = backend.setTreasureData(offset += 1, comboBox55.SelectedValue.ToString());
            bool result56 = backend.setTreasureData(offset += 1, comboBox56.SelectedValue.ToString());
            bool result57 = backend.setTreasureData(offset += 1, comboBox57.SelectedValue.ToString());
            bool result58 = backend.setTreasureData(offset += 1, comboBox58.SelectedValue.ToString());
            bool result59 = backend.setTreasureData(offset += 1, comboBox59.SelectedValue.ToString());
            bool result60 = backend.setTreasureData(offset += 1, comboBox60.SelectedValue.ToString());

            bool result61 = backend.setTreasureData(offset += 1, comboBox61.SelectedValue.ToString());
            bool result62 = backend.setTreasureData(offset += 1, comboBox62.SelectedValue.ToString());
            bool result63 = backend.setTreasureData(offset += 1, comboBox63.SelectedValue.ToString());
            bool result64 = backend.setTreasureData(offset += 1, comboBox64.SelectedValue.ToString());
            bool result65 = backend.setTreasureData(offset += 1, comboBox65.SelectedValue.ToString());
            bool result66 = backend.setTreasureData(offset += 1, comboBox66.SelectedValue.ToString());
            bool result67 = backend.setTreasureData(offset += 1, comboBox67.SelectedValue.ToString());
            bool result68 = backend.setTreasureData(offset += 1, comboBox68.SelectedValue.ToString());
            bool result69 = backend.setTreasureData(offset += 1, comboBox69.SelectedValue.ToString());
            bool result70 = backend.setTreasureData(offset += 1, comboBox70.SelectedValue.ToString());

            bool result71 = backend.setTreasureData(offset += 1, comboBox71.SelectedValue.ToString());
            bool result72 = backend.setTreasureData(offset += 1, comboBox72.SelectedValue.ToString());
            bool result73 = backend.setTreasureData(offset += 1, comboBox73.SelectedValue.ToString());
            bool result74 = backend.setTreasureData(offset += 1, comboBox74.SelectedValue.ToString());
            bool result75 = backend.setTreasureData(offset += 1, comboBox75.SelectedValue.ToString());
            bool result76 = backend.setTreasureData(offset += 1, comboBox76.SelectedValue.ToString());
            bool result77 = backend.setTreasureData(offset += 1, comboBox77.SelectedValue.ToString());
            bool result78 = backend.setTreasureData(offset += 1, comboBox78.SelectedValue.ToString());
            bool result79 = backend.setTreasureData(offset += 1, comboBox79.SelectedValue.ToString());
            bool result80 = backend.setTreasureData(offset += 1, comboBox80.SelectedValue.ToString());

            bool result81 = backend.setTreasureData(offset += 1, comboBox81.SelectedValue.ToString());
            bool result82 = backend.setTreasureData(offset += 1, comboBox82.SelectedValue.ToString());
            bool result83 = backend.setTreasureData(offset += 1, comboBox83.SelectedValue.ToString());
            bool result84 = backend.setTreasureData(offset += 1, comboBox84.SelectedValue.ToString());
            bool result85 = backend.setTreasureData(offset += 1, comboBox85.SelectedValue.ToString());
            bool result86 = backend.setTreasureData(offset += 1, comboBox86.SelectedValue.ToString());
            bool result87 = backend.setTreasureData(offset += 1, comboBox87.SelectedValue.ToString());
            bool result88 = backend.setTreasureData(offset += 1, comboBox88.SelectedValue.ToString());
            bool result89 = backend.setTreasureData(offset += 1, comboBox89.SelectedValue.ToString());
            bool result90 = backend.setTreasureData(offset += 1, comboBox90.SelectedValue.ToString());

            bool result91 = backend.setTreasureData(offset += 1, comboBox91.SelectedValue.ToString());
            bool result92 = backend.setTreasureData(offset += 1, comboBox92.SelectedValue.ToString());
            bool result93 = backend.setTreasureData(offset += 1, comboBox93.SelectedValue.ToString());
            bool result94 = backend.setTreasureData(offset += 1, comboBox94.SelectedValue.ToString());
            bool result95 = backend.setTreasureData(offset += 1, comboBox95.SelectedValue.ToString());
            bool result96 = backend.setTreasureData(offset += 1, comboBox96.SelectedValue.ToString());
            bool result97 = backend.setTreasureData(offset += 1, comboBox97.SelectedValue.ToString());
            bool result98 = backend.setTreasureData(offset += 1, comboBox98.SelectedValue.ToString());
            bool result99 = backend.setTreasureData(offset += 1, comboBox99.SelectedValue.ToString());
            bool result100 = backend.setTreasureData(offset += 1, comboBox100.SelectedValue.ToString());

            bool result101 = backend.setTreasureData(offset += 1, comboBox101.SelectedValue.ToString());
            bool result102 = backend.setTreasureData(offset += 1, comboBox102.SelectedValue.ToString());
            bool result103 = backend.setTreasureData(offset += 1, comboBox103.SelectedValue.ToString());
            bool result104 = backend.setTreasureData(offset += 1, comboBox104.SelectedValue.ToString());
            bool result105 = backend.setTreasureData(offset += 1, comboBox105.SelectedValue.ToString());
            bool result106 = backend.setTreasureData(offset += 1, comboBox106.SelectedValue.ToString());
            bool result107 = backend.setTreasureData(offset += 1, comboBox107.SelectedValue.ToString());
            bool result108 = backend.setTreasureData(offset += 1, comboBox108.SelectedValue.ToString());
            bool result109 = backend.setTreasureData(offset += 1, comboBox109.SelectedValue.ToString());
            bool result110 = backend.setTreasureData(offset += 1, comboBox110.SelectedValue.ToString());

            bool result111 = backend.setTreasureData(offset += 1, comboBox111.SelectedValue.ToString());
            bool result112 = backend.setTreasureData(offset += 1, comboBox112.SelectedValue.ToString());
            bool result113 = backend.setTreasureData(offset += 1, comboBox113.SelectedValue.ToString());
            bool result114 = backend.setTreasureData(offset += 1, comboBox114.SelectedValue.ToString());
            bool result115 = backend.setTreasureData(offset += 1, comboBox115.SelectedValue.ToString());
            bool result116 = backend.setTreasureData(offset += 1, comboBox116.SelectedValue.ToString());
            bool result117 = backend.setTreasureData(offset += 1, comboBox117.SelectedValue.ToString());
            bool result118 = backend.setTreasureData(offset += 1, comboBox118.SelectedValue.ToString());
            bool result119 = backend.setTreasureData(offset += 1, comboBox119.SelectedValue.ToString());
            bool result120 = backend.setTreasureData(offset += 1, comboBox120.SelectedValue.ToString());

            bool result121 = backend.setTreasureData(offset += 1, comboBox121.SelectedValue.ToString());
            bool result122 = backend.setTreasureData(offset += 1, comboBox122.SelectedValue.ToString());
            bool result123 = backend.setTreasureData(offset += 1, comboBox123.SelectedValue.ToString());
            bool result124 = backend.setTreasureData(offset += 1, comboBox124.SelectedValue.ToString());

            if (result1 && result2 && result3 && result4 && result5 && result6 && result7 && result8 && result9 && result10
                && result11 && result12 && result13 && result14 && result15 && result16 && result17 && result18 && result19 && result20
                && result21 && result22 && result23 && result24 && result25 && result26 && result27 && result28 && result29 && result30
                && result31 && result32 && result33 && result34 && result35 && result36 && result37 && result38 && result39 && result40
                && result41 && result42 && result43 && result44 && result45 && result46 && result47 && result48 && result49 && result50
                && result51 && result52 && result53 && result54 && result55 && result56 && result57 && result58 && result59 && result60
                && result61 && result62 && result63 && result64 && result65 && result66 && result67 && result68 && result69 && result70
                && result71 && result72 && result73 && result74 && result75 && result76 && result77 && result78 && result79 && result80
                && result81 && result82 && result83 && result84 && result85 && result86 && result87 && result88 && result89 && result90
                && result91 && result92 && result93 && result94 && result95 && result96 && result97 && result98 && result99 && result100
                && result101 && result102 && result103 && result104 && result105 && result106 && result107 && result108 && result109 && result110
                && result111 && result112 && result113 && result114 && result115 && result116 && result117 && result118 && result119 && result120
                && result121 && result122 && result123 && result124
                )
            {
                MessageBox.Show("ROM updated!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("ROM update failed.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
