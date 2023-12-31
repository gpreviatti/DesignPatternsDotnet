﻿using Strategy.Interface;

namespace Strategy;

public class TaxCalculator
{
    private readonly ITax _tax;

    public TaxCalculator(ITax tax) => _tax = tax;

    public float Calculate(float value) => _tax.Calculate(value);
}