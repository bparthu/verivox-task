# verivox-task

**Task: Tariff Comparison**
Develop a model to build up the following two products and to compare these products based on
their annual costs. The comparison should accept the following input parameter:
- Consumption (kWh/year)

and create a list of these products with the columns
- Tariff name
- Annual costs (€/year)
The list should be sorted by costs in ascending order.

**Products**
1. Product A
Name: “basic electricity tariff”
Calculation model: base costs per month 5 € + consumption costs 22 cent/kWh
Examples:
- Consumption = 3500 kWh/year => Annual costs = 830 €/year (5€ * 12 months = 60 €
base costs + 3500 kWh/year * 22 cent/kWh = 770 € consumption costs)
- Consumption = 4500 kWh/year => Annual costs = 1050 €/year (5€ * 12 months = 60 €
base costs + 4500 kWh/year * 22 cent/kWh = 990 € consumption costs)
- Consumption = 6000 kWh/year => Annual costs = 1380 €/year (5€ * 12 months = 60 €
base costs + 6000 kWh/year * 22 cent/kWh = 1320 € consumption costs)

2. Product B
Name: “Packaged tariff”
Calculation model: 800 € for up to 4000 kWh/year and above 4000 kWh/year additionally 30
cent/kWh.
Examples:
- Consumption = 3500 kWh/year => Annual costs = 800 €/year
- Consumption = 4500 kWh/year => Annual costs = 950 €/year (800€ + 500 kWh * 30
cent/kWh = 150 € additional consumption costs)
- Consumption = 6000 kWh/year => Annual costs = 1400 €/year (800€ + 2000 kWh * 30
cent/kWh = 600 € additional consumption costs)

**Notes:**
Please implement this task in C#, C++ or Java or any other object oriented language.
If you write tests for your implementation please provide them with your implementation.
Please develop only the logic described above, and no UI (webpage, etc.). You do not need a data
base. All sample data can be hardcoded or added to the implementation by any other method of
your choice.

# Technical specification
1. language / runtime selected: C# / .NET Core
2. Development model: Behaviour driven development using LightBDD framework
3. Design: 
  - three layer architecture:
    1. Model - Represents the data model class (eg, ProductModel).
    2. Domain - Business logic goes here. Used interface pattern to create different implementation of IProduct interface (eg., ProductA and ProductB)
    3. Service - This layer consumes domain layer, which makes it a better candidate for Dependency Injection.
  - Used Dependency Injection to inject service class into Main method.
  - BDD reports are added into repository, for easy access (see below section).
  - Dockerized the solution, hence it can run anywhere (see below section).

# Docker image
```
docker run --rm -e CONSUMPTION=2000 bpaarthu/tariff-compare:latest
```

# BDD Test report URL
[https://htmlpreview.github.io/?https://github.com/bparthu/verivox-task/blob/master/TariffCompare.spec/Reports/FeaturesReport.html](https://htmlpreview.github.io/?https://github.com/bparthu/verivox-task/blob/master/TariffCompare.spec/Reports/FeaturesReport.html).
