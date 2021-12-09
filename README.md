# StatBot
A Discord bot written in C# to do statistical / mathematical operations such as sampling, integrating, etc.
## Project Setup
### Getting the .NET SDK
**Manjaro Linux:** Follow [this](https://dev.to/kelvinmai/how-to-install-dotnet-core-in-manjaro-linux-590a) guide to installing .NET core SDK on Manjaro Linux

**Other OS:** Not sure. If you're on Windows, you can probably install it via Visual Studio.

All dependnencies should be installed within the solution, but if you're recreating the project from scratch, I used the following:
* [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection)
* [Discord .NET API](https://docs.stillu.cc/guides/getting_started/installing.html?tabs=vs-install%2Ccore2-1)

# Command List
Here's a list of commands sorted alphabetically.

## !diff
Take the difference of a list of numbers.
### Usage
`!diff <numeric args...>`
### Example
`!diff 1 2 3 4 5`

Output: `Difference: -13`

## !max
Take the maximum of a list of numbers.
### Usage
`!max <numeric args...>`
### Example
`!max 5 3 8 4 7 5 2 3`

Output: `Maximum: 8`

## !mean
Take the mean of a list of numbers.
### Usage
`!mean <numeric args...>`
### Example
`!min 5 3 8 4 7 5 2 3`

Output: `Mean: 4.625`

## !min
Take the minimum of a list of numbers.
### Usage
`!min <numeric args...>`
### Example
`!min 5 3 8 4 7 5 2 3`

Output: `Minimum: 2`

## !prod
Take the product of a list of numbers.
### Usage
`!prod <numeric args...>`
### Example
`!prod 1 2 3 4 5`

Output: `Product: 120`

## !sd
Take the (sample) standard deviation of a list of numbers.
### Usage
`!sd <numeric args...>`
### Example
`!sd 5 3 8 4 7 5 2 3`

Output: `Sample StDev: 2.065879266282796`


## !sum
Sum a list of numbers.
### Usage
`!sum <numeric args...>`
### Example
`!sum 1 2 3 4 5`

Output: `Sum: 15`

## !var
Take the (sample) variance of a list of numbers.
### Usage
`!var <numeric args...>`
### Example
`!var 5 3 8 4 7 5 2 3`

Output: `Sample Variance: 4.267857142857143`