### Pure Esport - Seeding Tournament Tree (Bracket) Algorithm (C#)

#### The problem
Given a tournament of ```n``` participants ```p```, for each round ```r``` in the tournament bracket, create a match ```m``` and pair the participants, but for each participant which does not have an opponent, advance them to the next round (bye / default win).

##### Example input
1, 2, 3, 4, 5, 6, 7, 8 (8 contestants)

##### Expected ouput pairs
* 1 v 8
* 5 v 4
* 3 v 6
* 7 v 2

##### Example input #2
1, 2, 3, 4, 5 (5 contestants)

##### Expected ouput pairs
* 1 v 4
* 3 v 2
* 5 (bye)
