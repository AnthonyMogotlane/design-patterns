```mermaid

    classDiagram
	class IBurger{
		<<interface>>
		GetBurgerType() string
	}
	
	IBurger <|.. Burger
	
	class Burger {
		+GetBurgerType() string
	}
	
	IBurger <|.. BurgerDecorator
	
	class BurgerDecorator {
		-burger : IBurger
		+BurgarDecorator(burger : IBurger)
		vertual +GetBurgerType() string
	}
	
	BurgerDecorator <|-- CheeseDecorator
	
	class CheeseDecorator {
		+CheeseDecorator(burger : IBurger)
		override +GetBurgerType() string
	}

	BurgerDecorator <|-- TomatoDecorator
	
	class TomatoDecorator {
		+TomatoDecorator(burger : IBurger)
		override +GetBurgerType() string
	}
	
