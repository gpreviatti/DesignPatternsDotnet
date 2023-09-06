using Decorator;

// Without decorator
var onlyIcmsTax = new IcmsTax().Handle(120);
Console.WriteLine(onlyIcmsTax);

// Ims and Icss combined
var icsmIssTax = new IcmsTax(new IssTax()).Handle(120);
Console.WriteLine(icsmIssTax);