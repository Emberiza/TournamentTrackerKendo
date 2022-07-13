# Kendo Tournament Tracking application based on the [tutorial by Tim Corey](https://www.youtube.com/watch?v=wfWxdh-_k_4) for class AK8PO
## Poznámky k projektu:


- Kendo turnaj je ve formátu elimination match (pouze pavouk, žádný pooling)

- Ceny implementovány pouze pro první dvě místa, z důvodu Tima Coreyho, který prohlásil, že je to příliš náročné/zdlouhavé

- Z důvodu strukturalizace databáze, jsou týmy implementovány tak, že je v nich pouze jeden zápasník

- Dan a Kyu ranky jsou zjednodušeny, z důvodu MS SQL databáze (věčné problémy, nestabilita, atd.)

- Pokoušel jsem ses o filtrování listboxu zápasníků podle ranku, ovšem, nepovedlo se mi, tudíž uživatel má u každého zápasníka zobrazen rank

- Custom eventy jsou zhotoveny například ve formě chybových hlášek špatně zadaných bodů (remíza, více než 2, záporné)

- Zanshin (trvalá fyzická a duševní bdělost) bohužel neimplementována :)

## Bugy

- Email bug: posílání emailů za pomoci C# je funkční, ovšem občas se emailů pošle více, nežli by se mělo (duplikáty). Čím více zápasníků, tím více duplikovaných emailů se pošle. Například v zápase 1v1, přijde jednomu zápasníkovi email, že má soupeřit sám se sebou. Pomocí debuggingu jsem přišel na problematický úsek kódu, nebyl jsem ale schopen jej napravit, protože si myslím, že to má co dočinění se strukturalizací databáze (a faktem, že jeden tým = jeden člověk) Problematický úsek kódu je označem v #TODO

## Harmonogram

- Plánování aplikace - 1 hodina

- Tvorba prvotních forem - 3 hodiny

- Tvoření modelů - 2 hodiny

- Dodělání prvních forem (Prize) - 2 hodiny

- Opakované problémy s MS SQL databází - 3 hodiny

- Tvoření SQL databáze - 5 hodin

- Tvoření propojovacích class pro SQL databázi: 2 hodiny

- Tvorba Team forem - 2 hodiny 

- Tvorba formy pro vytvoření turnaje - 7 hodin 

- Tvoření SQL procedur: 5 hodin

- Tvorba prvotní menu formy - 1 hodina

- Tvorba formy pro shlédnutí/operování turnaje - 3 hodiny

- Tvorba turnajové logiky - 3 hodiny

- Tvorba posílání emailu za pomoci C# - 2 hodiny

- Nastudování Kenda: 2 hodiny

- Přetvoření aplikace z basketbalové na Kendo: 7 hodin

## Finální čas na vytvoření aplikace: 50 hodin

# Závěr

Programování této aplikace byl celkově jedna ze zábavnějších předmětů tohoto semestru. S C# jsem měl lehké zkušenosti z jednoho předmětu na bakalářském studiu, ovšem v tom jsme nezacházeli tak podrobně do věcí jako LINQ či Dapper. Největším problémem programování této aplikace byla rozhodně Microsoft SQL Databáze, která se mnou na každém kroku nechtěla spolupracovat. Projekt by se rozhodně dal vylepšit, například věcmi, které jsem nebyl schopen vyřešit (filtrování listboxu z databáze, či generace grafického turnajového pavouka), ovšem již tak jsem přesáhl doporučený časový limit tvorby aplikace. 




























