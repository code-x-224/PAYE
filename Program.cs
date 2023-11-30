

// MY VARIABLES


using System.Data;
using System.Security.Cryptography.X509Certificates;

double UpTo = 24_000;
double Over = 250_000;
double lower_lim_1 = 24_001;
double upper_lim_1 = 40_000;

double lower_lim_2 = 40_001;
double upper_lim_2 = 60_000;

double lower_lim_3 = 60_001;
double upper_lim_3 = 100_000;

double lower_lim_4 = 100_001;
double upper_lim_4 = 150_000;

double lower_lim_5 = 150_001;
double upper_lim_5 = 250_000;

double rate_UpT0 = 0.10;

double rate_Over = 0.40;

double rate_1 = 0.15;

double rate_2 = 0.20;

double rate_3 = 0.25;

double rate_4 = 0.30;

double rate_5 = 0.35;

bool On = true;

string taxComplianceStatus = "Approved";

Welcome();

Console.WriteLine("Enter your name: \v");
string taxpayerName = Console.ReadLine();

Console.Clear();
Welcome();

Console.WriteLine("Enter Your Tax ID:\v");
string taxpayerId = Console.ReadLine();


Console.Clear();
Welcome();

// USER INPUTS


//monthly salary - check

string prompt_1 = "\vEnter your monthly salary:";
string promt_2 = "\v> ";

Console.Write(prompt_1 + promt_2);
while (On)
{
    string try_again = "\vTry again: ";

    try
    {
        double monthly_income = double.Parse(Console.ReadLine());
        //allowances - check
        bool allAccounted = true;
        int allowance_counter = 1;
        Console.WriteLine("\vEnter Allowances: ");

        Console.Write($"\v\tAlowance {allowance_counter}: ");

        double allowance;

        allowance = Convert.ToDouble(Console.ReadLine());
        bool loop_on = true;
        while (allAccounted)
        {
            Console.Clear();
            Thread.Sleep(500);
            Welcome();
            Console.WriteLine("Is that all (For allowance)?\v");
            Console.WriteLine("Please answer Yes or  No\v");
            Console.Write("> ");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "no")
            {

                allowance_counter++;
                Console.Clear();
                Welcome();
                Console.Write($"\vAlowance {allowance_counter}: ");
                double allow_again = Convert.ToDouble(Console.ReadLine());
                allowance += allow_again;

            }
            else if (choice.ToLower() == "yes")
            {
                allAccounted = false;
            }

            else
            {
                Console.WriteLine("Invalid input!!");
            }




        }
        Console.WriteLine($"The total for your allowances is: {allowance}\v");
        Thread.Sleep(2500);

        // deductions - check

        bool deduct_Accounted = true;
        int deduction_counter = 1;

        Console.WriteLine("Enter Deduction: ");

        Console.Write($"\tDeduction {deduction_counter}: ");
        double deduction = Convert.ToDouble(Console.ReadLine());
        while (deduct_Accounted)
        {
            Console.Clear();
            Thread.Sleep(500);
            Welcome();
            Console.WriteLine("Is that all (For deductions)?\v");
            Console.WriteLine("Please answer Yes or  No\v");
            Console.Write("> ");

            string choice_ded = Console.ReadLine();

            if (choice_ded.ToLower() == "no")
            {

                deduction_counter++;
                Console.Clear();
                Welcome();
                Console.Write($"\vDeduction {deduction_counter}: ");
                double deduct_again = Convert.ToDouble(Console.ReadLine());
                deduction += deduct_again;

            }
            else if (choice_ded.ToLower() == "yes")
            {
                deduct_Accounted = false;
            }





        }
        Thread.Sleep(700);

        Console.WriteLine($"The total for your deductions is: {deduction}\v");


        // TAXABLE INCOME

        double taxable_income = (monthly_income + allowance);


        // TAX PAYABLE

        double tax_payable;

        //calculate tax payable

        if (taxable_income > UpTo)
        {




            if (taxable_income > Over)
            {
                tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) +
                                ((upper_lim_3 - lower_lim_3) * rate_3) + ((upper_lim_4 - lower_lim_4) * rate_4) +
                                 ((upper_lim_5 - lower_lim_5) * rate_5) + ((taxable_income - Over) * rate_Over);
                CalculationWait();
                Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                net_income(taxable_income, deduction, tax_payable);
                TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

            }

            if (taxable_income > upper_lim_4 && taxable_income <= upper_lim_5)
            {
                if (taxable_income < upper_lim_5)
                {
                    upper_lim_5 = taxable_income;

                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) +
                                    ((upper_lim_3 - lower_lim_3) * rate_3) + ((upper_lim_4 - lower_lim_4) * rate_4) + ((upper_lim_5 - lower_lim_5) * rate_5);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
                else
                {
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) +
                                    ((upper_lim_3 - lower_lim_3) * rate_3) + ((upper_lim_4 - lower_lim_4) * rate_4) + ((upper_lim_5 - lower_lim_5) * rate_5);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
            }

            if (taxable_income > upper_lim_3 && taxable_income <= upper_lim_4)
            {
                if (taxable_income < upper_lim_4)
                {
                    upper_lim_4 = taxable_income;

                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) +
                                ((upper_lim_3 - lower_lim_3) * rate_3) + ((upper_lim_4 - lower_lim_4) * rate_4);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
                else
                {
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) +
                               ((upper_lim_3 - lower_lim_3) * rate_3) + ((upper_lim_4 - lower_lim_4) * rate_4);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
            }

            if (taxable_income > upper_lim_2 && taxable_income <= upper_lim_3)
            {
                if (taxable_income < upper_lim_3)
                {
                    upper_lim_3 = taxable_income;
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) + ((upper_lim_3 - lower_lim_3) * rate_3);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
                else
                {
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2) + ((upper_lim_3 - lower_lim_3) * rate_3);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }

            }

            if (taxable_income > upper_lim_1 && taxable_income <= upper_lim_2)
            {
                if (taxable_income < upper_lim_2)
                {
                    upper_lim_2 = taxable_income;
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
                else
                {
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1) + ((upper_lim_2 - lower_lim_2) * rate_2);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
            }

            if (taxable_income > UpTo && taxable_income <= upper_lim_1)
            {
                if (taxable_income < upper_lim_1)
                {
                    upper_lim_1 = taxable_income;
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }

                else
                {
                    tax_payable = (UpTo * rate_UpT0) + ((upper_lim_1 - lower_lim_1) * rate_1);
                    CalculationWait();
                    Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}.Good day!!");
                    net_income(taxable_income, deduction, tax_payable);
                    TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

                }
            }
        }

        else if (taxable_income <= UpTo)
        {
            tax_payable = (taxable_income * rate_UpT0);
            CalculationWait();
            Console.WriteLine($"Hello, you are to pay Ksh{tax_payable:C2}");
            net_income(taxable_income, deduction, tax_payable);
            TaxComplianceDisplay(taxpayerName, taxpayerId, monthly_income, tax_payable, taxComplianceStatus);

        }


        On = false;

    }


    catch (FormatException)
    {

        Console.Clear();
        Welcome();
        Console.WriteLine($"Please enter a numerical value!!");
        string try_again_1 = prompt_1;
        string try_again_2 = promt_2;


        Console.Write(try_again + prompt_1 + promt_2);

    }
}

Console.ReadKey();





static void Welcome()
{
    Console.WriteLine("\v\t");
    for (int i = 0; i < 100; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine("\v\v\t\t\t\tWELCOME TO CODE_X TAX CALCULATOR!!\v");

    for (int i = 0; i < 100; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine("\v");


}


static void net_income(double Taxable_income, double Deduction, double Tax_payable)
{
    double net_income = Taxable_income - (Deduction + Tax_payable);

    Console.WriteLine($"\v\tYour net income is Ksh{net_income}. Thankyou!!");
    Thread.Sleep(3000);
}
static void CalculationWait()
{
    Random random = new Random();
    int rand_delay = random.Next(50, 100);
    int rand_int = random.Next(1, 4);
    for (int i = 0; i < rand_int; i++)
    {
        Console.Write("\v\t$ Calculating Tax");
        Thread.Sleep(rand_delay);
        Console.Write(" .");
        Thread.Sleep(rand_delay);
        Console.Write(" .");
        Thread.Sleep(rand_delay);
        Console.Write(" .");
        Thread.Sleep(rand_delay);
        Console.Clear();



    }
}

static void TaxComplianceDisplay(string TaxpayerName, string TaxpayerId, double Income, double TaxPaid, string TaxComplianceStatus)
{


    Console.Clear();
    // Print the certificate
    Console.WriteLine("\nCertificate of Tax Compliance\n");
    Console.WriteLine("===================================");
    Console.WriteLine($"Taxpayer Name: {TaxpayerName}");
    Console.WriteLine($"Taxpayer ID: {TaxpayerId}");
    Console.WriteLine($"Taxable Income: ${Income:N2}");
    Console.WriteLine($"Total Tax Paid: ${TaxPaid:N2}");
    Console.WriteLine("===================================");
    Console.WriteLine($"Tax Compliance Status: {TaxComplianceStatus}");
    Console.WriteLine("===================================");

    Console.ReadKey();

}
