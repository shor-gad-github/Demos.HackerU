﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Demos.HackerU.Wpf
{

    public enum Operation
    {
        Plus,
        Minus,
        Multiply,
        Divide
    }


    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        public CalculatorWindow()
        {
            InitializeComponent();
        }



        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

            float? num1 = ValidateNumber(txtBox1.Text);
            float? num2 = ValidateNumber(txtBox2.Text);

            if (num1.HasValue && num2.HasValue)
            {
                float res = Calculate(num1.Value,num2.Value,Operation.Minus);
                txtBoxResult.Text = res.ToString();
                
                txtBox1.Text = "";
                txtBox2.Clear();

            }
           else
            {
                MessageBox.Show("ERROR NUMBER FORMAT");
            }

        }

        private float? ValidateNumber(string textNumber)
        {
            float? parse = null;

            bool isValid = float.TryParse(textNumber, out float numberValue);
            if (isValid)
            {
                parse = numberValue;
            }
            return parse;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private float Calculate(float num1, float num2, Operation operation)
        {
            float result = 0;
            switch (operation)
            {
                case Operation.Plus:
                    {
                        result = num1 + num2;
                        break;
                    }
                case Operation.Minus:
                    {
                        result = num1 - num2;
                        break;
                    }
                case Operation.Multiply:
                    {
                        result = num1 * num2;
                        break;

                    }
                case Operation.Divide:
                    {
                        result = num1 / num2;
                        break;
                    }

            }
            return result;
        }
   
    


    
    }
}
