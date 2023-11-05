using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algor
{
    public partial class MainAl : Form
    {
        public MainAl()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private int[] numbers; // Declare an array to store the numbers.
        private readonly object lbSortingSteps;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Call GetNumbersFromTextBox to update the 'numbers' array.
            numbers = GetNumbersFromTextBox();
        }
        public int[] GetNumbersFromTextBox()
        {
            string inputText = textBox1.Text;
            string[] numberStrings = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numberList = new List<int>();
            foreach (string numString in numberStrings)
            {
                if (int.TryParse(numString, out int number))
                {
                    numberList.Add(number);
                }
            }

            return numberList.ToArray();
        }

        private void cbCoctail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCoctail.Checked)
            {
                // The "Cocktail Sort" checkbox is checked.
                // Perform the Cocktail Sort here.
                int[] arr = GetNumbersFromTextBox(); // Implement GetNumbersFromTextBox() to retrieve the numbers.
                CocktailSortAlgorithm(arr);

            }
        }
        public static void CocktailSortAlgorithm(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            bool swapped;

            do
            {
                swapped = false;

                // Move the largest element to the right
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        swapped = true;
                    }
                }
                right--;

                if (!swapped)
                    break;
                // Move the smallest element to the left
                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        Swap(arr, i, i - 1);
                        swapped = true;
                    }
                }
                left++;
            } while (swapped);
        }
        public static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


        private void cbGnom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGnom.Checked)
            {
                // The "Gnome Sort" checkbox is checked.
                // Perform the Gnome Sort here.
                int[] numbers = GetNumbersFromTextBox(); // Implement GetNumbersFromTextBox() to retrieve the numbers.
                DwarfSort.DwarfSortAlgorithm(numbers); // Call the method from the DwarfSort class.

            }
        }
        public class DwarfSort
        {
            public static void DwarfSortAlgorithm(int[] arr)
            {
                int index = 0;
                while (index < arr.Length)
                {
                    if (index == 0 || arr[index] >= arr[index - 1])
                    {
                        index++;
                    }
                    else
                    {
                        Swap(arr, index, index - 1);
                        index--;
                    }
                }
            }

            public static void Swap(int[] arr, int index1, int index2)
            {
                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }
        }

        private void cbCyclic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCyclic.Checked)
            {
                // The "Cyclic Sort" checkbox is checked.
                // Perform the Cyclic Sort here.
                int[] numbers = GetNumbersFromTextBox(); // Implement GetNumbersFromTextBox() to retrieve the numbers.
                CyclicSort.CyclicSortAlgorithm(numbers); // Call the method from the CyclicSort class.

            }
        }
        public class CyclicSort
        {
            public static void CyclicSortAlgorithm(int[] arr)
            {
                int n = arr.Length;
                for (int i = 0; i < n;)
                {
                    if (arr[i] != i + 1)
                    {
                        if (arr[i] >= 1 && arr[i] <= n)
                        {
                            Swap(arr, i, arr[i] - 1);
                        }
                        else
                        {
                            i++;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            public static void Swap(int[] arr, int index1, int index2)
            {
                int temp = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = temp;
            }

            public static void PrintArray(int[] arr)
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }


        private void MainAl_Load(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            if (cbCoctail.Checked)
            {
                int[] numbers = GetNumbersFromTextBox();
                CocktailSortAlgorithm(numbers);
                result = GenerateResult(numbers);
            }
            else if (cbGnom.Checked)
            {
                int[] numbers = GetNumbersFromTextBox();
                DwarfSort.DwarfSortAlgorithm(numbers);
                result = GenerateResult(numbers);
            }
            else if (cbCyclic.Checked)
            {
                int[] numbers = GetNumbersFromTextBox();
                CyclicSort.CyclicSortAlgorithm(numbers);
                result = GenerateResult(numbers);
            }

            // Display the result in the output TextBox.
            tbOutput.Text = result;
        }
        private string GenerateResult(int[] sortedArray)
        {
            // Implement your logic to generate the result here.
            // For example, if you want to display the sorted array as a string:
            string result = string.Join(", ", sortedArray); // Assuming you want to display the sorted array as a comma-separated string.



            return result;
        }


        private void tbOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
