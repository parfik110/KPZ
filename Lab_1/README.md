# Принципи проектування коду

## KISS (Keep It Simple, Stupid)
Кожен клас і метод має чітке призначення, що робить код простим і зрозумілим.  
Наприклад, `Money.ToString()`. [`Money.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Money.cs)

## DRY (Don't Repeat Yourself)
Логіка додавання товарів використовується у методах [`AddProduct`](https://github.com/parfik110/KPZ/blob/bab2f94baef01d191b173f9d53e5ab8233edaba9/Lab_1/ClassLibrary/Warehouse.cs#L7) класу `Warehouse`, а не дублюється у різних місцях.  
[`Warehouse.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Warehouse.cs)

## SOLID

### SRP (Single Responsibility Principle)
Кожен клас відповідає за конкретну функціональність.  
- `Product` - зберігає інформацію про товар.  
- `Warehouse` - керує запасами.  
[`Product.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Product.cs), [`Warehouse.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Warehouse.cs)

### OCP (Open/Closed Principle)
Можна додавати нові типи звітів без зміни існуючого коду.  
Наприклад, [`Reporting.RegisterIncome()`](https://github.com/parfik110/KPZ/blob/bab2f94baef01d191b173f9d53e5ab8233edaba9/Lab_1/ClassLibrary/Reporting.cs#L11).  
[`Reporting.cs`]([./Reporting.cs](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Reporting.cs))

### LSP (Liskov Substitution Principle)
Всі об'єкти можуть бути замінені на свої базові класи без порушення логіки.  
[`Product.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Product.cs)

### ISP (Interface Segregation Principle)
Кожен клас використовує лише необхідні йому методи та властивості.  
[`Money.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Money.cs)

### DIP (Dependency Inversion Principle)
Залежності передаються в методи, а не створюються всередині класів.  
Наприклад, [`Reporting.RegisterIncome()`](https://github.com/parfik110/KPZ/blob/bab2f94baef01d191b173f9d53e5ab8233edaba9/Lab_1/ClassLibrary/Reporting.cs#L11) використовує [`Warehouse`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Warehouse.cs).  
[`Program.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ConsoleApp/Program.cs)

## YAGNI (You Aren't Gonna Need It)
Реалізовані тільки необхідні методи.  
Наприклад, [`RemoveProduct`](https://github.com/parfik110/KPZ/blob/bab2f94baef01d191b173f9d53e5ab8233edaba9/Lab_1/ClassLibrary/Warehouse.cs#L21) у [`Warehouse`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Warehouse.cs) з'являється лише тоді, коли це потрібно.  
[`Warehouse.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Warehouse.cs)

## Composition Over Inheritance
`Product` має об'єкт `Money`, а не успадковує його.  
Це дозволяє легко змінювати логіку ціни без зміни структури класів.  
[`Product.cs`](https://github.com/parfik110/KPZ/blob/main/Lab_1/ClassLibrary/Product.cs)
