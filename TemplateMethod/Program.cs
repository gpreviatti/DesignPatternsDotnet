using TemplateMethod;

var discountFiftyPercent = new DiscountFiftyPercent().Handle(500);
Console.WriteLine(discountFiftyPercent);

var discountTwentyPercent = new DiscountTwentyPercent().Handle(150);
Console.WriteLine(discountTwentyPercent);