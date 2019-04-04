﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ourglass
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly int[] presetTime = { 15, 20, 30, 45, 60, 90, 120, 150 }; // 시간 콤보박스에 사용하는, 상수 배열

        public MainWindow()
        {
            InitializeComponent();
            for (int i=0; i < presetTime.Length; i++) // 시간 콤보박스에 미리 설정된 시간 (분) 추가
            {
                cmbTime.Items.Add(presetTime[i]);
            }
            cmbTime.SelectedIndex = 2;
            
        }
    }
}