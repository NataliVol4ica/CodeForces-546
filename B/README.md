# B. Nastya Is Playing Computer Games

Finished her homework, Nastya decided to play computer games. 
Passing levels one by one, Nastya eventually faced a problem.
Her mission is to leave a room, where a lot of monsters live, as quickly as possible.

There are n manholes in the room which are situated on one line, but, unfortunately, 
all the manholes are closed, and there is one stone on every manhole. 
There is exactly one coin under every manhole, and to win the game Nastya should pick all the coins.
Initially Nastya stands near the k-th manhole from the left. She is thinking what to do.

In one turn, Nastya can do one of the following:
- if there is at least one stone on the manhole Nastya stands near,
throw exactly one stone from it onto any other manhole (yes, Nastya is strong).
- go to a neighboring manhole;
- if there are no stones on the manhole Nastya stays near, she can open it and pick the coin from it. 
After it she must close the manhole immediately (it doesn't require additional moves). 

Nastya can leave the room when she picks all the coins. 
Monsters are everywhere, so you need to compute the minimum number of moves Nastya has to make to pick all the coins.

Note one time more that Nastya can open a manhole only when there are no stones onto it.

## Input

The first and only line contains two integers n and k, separated by space.
(2≤n≤5000, 1≤k≤n) — the number of manholes and the index of manhole from the left, 
near which Nastya stays initially. Initially there is exactly one stone near each of the n manholes.

## Output

Print a single integer — minimum number of moves which lead Nastya to pick all the coins.
