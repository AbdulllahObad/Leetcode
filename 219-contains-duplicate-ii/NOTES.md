The Idea : If duplicate element is present at distance less  than or  equal to k, return true...
How to Solve This Problem ? 😕
We Are Going To Bild a HshSet
We Will Elements In It Until We Reach  The Size of K+1 Why ?
We Because  We Know Tha IF Ther Are Duplicate Number Within The boundry Of k
The abs Diff Will be less Than K.  EX 😐?  OK 😊
* 0  1  2  3
* 1  2  3  1     K=3
Our HashSet  [1] Then [1,2] then [1,2,3]
then We Want To Add The 1 right ?
But We Cant Add It Because We Can Add only Diff Elments in A hashSet
Then Return True .
let's THange It A little bit  Like K=2
* 0  1  2  3
* 1  2  3  1     K=2
Our Hash Set Will Be Like
[1] Then [1,2]  then [1,2,3]
Ther Is no need To look For A Dublicate After That (Even If Ther is )
Because ( 3 -0 ) > 2
So We Are Loking For A Dublicate "If and only if" It's Within The
boundry of K .
​
​
​
​