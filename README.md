# 019 And Or

[![019 And Or](https://img.youtube.com/vi/TWBRz_5qQRw/0.jpg)](https://www.youtube.com/watch?v=TWBRz_5qQRw)

the Verifier.cs file
- should create a method named `Taxable` that takes two parameters `state` and `taxExempt` and returns the string "is taxable" if the `state` is `IA` and `taxExempt` is `false`
- should return an empty string ("") from `Taxable` if the `state` is `IA` and `taxExempt` is `true`
- should return an empty string ("") from `Taxable` if the `state` is `FL` and `taxExempt` is `false`
- should create a method named `IsVehicle` that takes three parameters `hasWheels`, `canFly`, `canSwim` and returns the string "is vehicle" if at least one of the three parameters evaluates to true
- should return the string "is vehicle" from `IsVehicle` when `hasWheels` is true and `canFly` and `canSwim` are both false
- should return the string "is vehicle" from `IsVehicle` when `canFly` is true and `hasWheels` and `canSwim` are both false
- should return the string "is vehicle" from `IsVehicle` when `canSwim` is true and `canFly` and `hasWheels` are both false
- should return the string "is vehicle" from `IsVehicle` when `canSwim` and `canFly` are both true and `hasWheels` is false
- should return an empty string ("") from `IsVehicle` when `hasWheels`, `canFly`, and `canSwim` are all false

Resources:
- https://www.w3schools.com/cs/cs_methods.php
- https://www.w3schools.com/cs/cs_operators_comparison.php
- https://www.w3schools.com/cs/cs_data_types.php


Copyright &copy; 2023 Knight Moves. All Rights Reserved.

