<?php
  
$annualExpenses = [
    "vacations" => 1000,
    "carRepairs" => 1000,    
];

$monthlyExpenses = [
    "rent" => 1500,
    "utilities" => 200,
    "healthInsurance" => 200
];

$grossSalary = 48150;
$socialSecurity = $grossSalary * .062;

$incomeSegments = [[9700, .88], [29775, .78], [8675, .76]];

// Write your code below:
$netIncome = ($incomeSegments[0][0] * $incomeSegments[0][1]) + ($incomeSegments[1][0] * $incomeSegments[1][1]) + ($incomeSegments[2][0] * $incomeSegments[2][1]);

$annualIncome = $netIncome - $socialSecurity;
echo "Annual Income: $${annualIncome}\n \n";

$annualIncome = $annualIncome - ($annualExpenses["vacations"]) - ($annualExpenses["carRepairs"]);

echo "Annual Income (- Annual Expenses): $${annualIncome}\n \n";

$monthlyIncome = $annualIncome / 12; 

echo "Monthly Income: $${monthlyIncome} \n \n";

$monthlyIncome = $monthlyIncome - ($monthlyExpenses["rent"]) - ($monthlyExpenses["utilities"]) - ($monthlyExpenses["healthInsurance"]);

echo "Monthly Income (- Monthly Expenses): $${monthlyIncome} \n \n";

$avgWeeksPerMonth = 4.33;

$weeklyIncome = $monthlyIncome / $avgWeeksPerMonth;

echo "Weekly Income: $${weeklyIncome} \n \n";

$weeklyExpenses = ["gas" => 25, "food" => 90, "entertainment" => 47];

$weeklyIncome = $weeklyIncome - ($weeklyExpenses["gas"]) - ($weeklyExpenses["food"] - ($weeklyExpenses["entertainment"]));

echo "Weekly Income (- Weekly Expenses): $${weeklyIncome} \n \n";

$weeksPerYear = 52;

$annualSavings = $weeklyIncome * $weeksPerYear;

echo "Annual Savings Amount: $${annualSavings} \n \n";