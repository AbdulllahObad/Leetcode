**The approach to sove this problem**

The problem is asking us to determine if a given string of brackets is valid. We need to ensue that each open bracket has a corresponding closing bracket of the same type, and they are in the correct order.
I've chosen to use a stack data strucutre to keep track of the open brackets. As we iterate through the string:
* We push open brackets onto the stack.
* We pop them off when we encounter the coresponding closing brackets.
At the end, if the stack is empty, that means all brackets were closed correctly, and the string is valide.

**The strcutre of the code**
​
I have the function called IsValide that takes a string s as input. Inside the function iI initialize an empty stack and create a mapping of closing brackets to their coresponding open brackets.
​
Then, I iterate through each character in the inputs string.
If the character is an open bracket, I push it onto the stack.
If it's closing bracket, I check if the stack is empty or if the top of the stack matches the    expected open bracket. If no, the string is not valid.
additionally, if the character is neither an open nor a closing bracket, the string is also not valid.
Finally, after processing the entire string, I check if the stack is empty. If it's , the string is valid, otherwise, it's not.

**The time and space complexity of your solution**
​
The time complexity is O(n), where n is the length of the input string. We iterate through the string once, and each operation inside the loop takes constant time.
​
The space complexity is also O(n) in the worst case. This occurs when the input string contains only open brackets. In the best case, when the string is valid, the stack would be empty, resulting in O(1) space complexity.
​
​
​
​
​
​
​
​
​
​
​
​
