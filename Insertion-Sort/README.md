# Insertion Sort

With Insertion Sort we compare the current element with the element ahead of it. Lets use a unsorted array of numbers as an example, if the number ahead is smaller then the current number then we can toss is behind and keep going with the current number. All the numbers behind the current number will also get sorted as we move down the array. Insertion sort is very similar to how most people organise a hand of playing cards.

## Complexity

| Best            | Average             | Worst               |
| :-------------: | :-----------------: | :-----------------: | 
| n               | n<sup>2</sup>       | n<sup>2</sup>       |

## How it works
1. Select a starting point (usually this is the first index or last)
2. Compare the current index vs the index+1
  - IF current index is larger then move the index+1 into the behind array
  - IF current index is smaller then index+1 then take index+1 as the new pointer and put index in the behind array
3. repeat step 2 recursivly until there are no more numbers in the array. 

## Examples

![Sorting example](https://thumbs.gfycat.com/SilkyBrownHoverfly-size_restricted.gif)
![Sorting example](https://thumbs.gfycat.com/UnfinishedBoldGenet-size_restricted.gif)
![Sorting example](https://thumbs.gfycat.com/CornyThickGordonsetter-small.gif)

##### Links
- https://www.youtube.com/watch?v=OGzPmgsI-pQ