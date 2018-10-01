﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciTest {
    public partial class FibonacciForm : Form {
        private long n1 = 0; // initialize with first Fibonacci number
        private long n2 = 1; // initialize with second Fibonacci number
        private int count = 1; // current Fibonacci number to display

        public FibonacciForm() {
            InitializeComponent();
        }

        // start an async Task to calculate specified Fibonacci number
        private async void calculateButton_Click(object sender, EventArgs e) {
            // retrieve user's input as an integer
            int number = int.Parse(inputTextBox.Text);
            asyncResultLabel.Text = "Calculating...";

            // Tast to perform Fibonacci calculation in separate thread
            Task<long> fibonacciTask = Task.Run(() => Fibonacci(number));

            // wait for Task in separate thread to complete
            await fibonacciTask;

            // display result after Task in separate thread completes
            asyncResultLabel.Text = fibonacciTask.Result.ToString();
        }

        // calculate next Fibonacci number iteratively
        private void nextNumberButton_Click(object sender, EventArgs e) {
            // calculate the next Fibonacci number
            long temp = n1 + n2; // calculate next Fibonacci number
            n1 = n2; // store prior Fibonacci number in n1
            n2 = temp; // store new Fibonacci
            ++count;

            // display the next Fibonacci number
            displayLabel.Text = $"Fibonacci of {count}:";
            syncResultLabel.Text = n2.ToString();
        }

        // recursive method Fibonacci; calculates nth Fibonacci number
        public long Fibonacci(long n) {
            if (n == 0 || n == 1) {
                return n;
            } else {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
