# Merge Sort

Merge sort is a very quick way to sort array/lists. It uses the Conquer and Divide strategy. 

## Complexity Table

| Best            | Average             | Worst               | Memory    |
| :-------------: | :-----------------: | :-----------------: | :-------: |
| n&nbsp;log(n)   | n&nbsp;log(n)       | n&nbsp;log(n)       | n         |

## How it works
<!-- 1. Make a new Array that will contain the sorted elements.
2. Take the input array and split it in half.
3. In each array we get the smallest number and add it to the array we created earlier in step 1. 
4. Repeat steps till arrays are empty. -->

1. We get an unsorted array as an input.
2. Divide the arrays iteratively, until we can't anymore.
3. Then we sort/compare 2 neighboring elements at a time. (Ex: [235, 100] => [100, 235])
4. We repeat comparing neighboring elements, and combining them.

## Examples
![Merge Sort example](https://upload.wikimedia.org/wikipedia/commons/c/cc/Merge-sort-example-300px.gif)
![Merge Sort example](https://thumbs.gfycat.com/ZealousAdolescentBellsnake-size_restricted.gif)
![Merge Sort example](https://gifimage.net/wp-content/uploads/2017/10/merge-sort-gif-9.gif)

##### MORE LINKS TO LEARN INSERTION SORT
- https://www.youtube.com/watch?v=KF2j-9iSf4Q
- https://www.tutorialspoint.com/data_structures_algorithms/merge_sort_algorithm.htm