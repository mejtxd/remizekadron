# Remízek a dron
Nástroj pro výpočet GPS polohy místa údržby

## Popis projektu
Tento projekt poskytuje jednoduchý nástroj pro výpočet GPS souřadnic místa, kde je potřeba provést údržbu, na základě videozáznamu pořízeného dronem. Dron se pohybuje konstantní rychlostí podél remízku a operátor vyhodnocuje video. Pokud operátor na záznamu zaznamená místo, které vyžaduje údržbu, zadá časový údaj z videa spolu s počátečními a koncovými GPS souřadnicemi dronu, délkou dráhy a dobou letu. Nástroj vypočítá přesné GPS souřadnice místa údržby.

## Vstupní údaje
1. Uživatel zadává následující vstupní údaje:
2. Počáteční GPS souřadnice (latitude a longitude)
3. Koncové GPS souřadnice (latitude a longitude)
4. Celkovou délku dráhy dronu (v metrech)
5. Celkovou dobu letu dronu (v sekundách)
6. Čas na videu, kde je vidět místo údržby (v sekundách)

## Výpočet
1. Nástroj nejprve vypočítá rychlost dronu v metrech za sekundu.
2. Na základě zadaného času na videu určí vzdálenost, kterou dron urazil od počátečního bodu.
3. Vypočítá podíl této vzdálenosti na celkové dráze.

