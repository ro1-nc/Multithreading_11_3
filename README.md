# Multithreading_11_3
Whenever there’s a long operation in your App, we want to show an “In Progress” popup.
We have no way of knowing how much time this operation will last, but it usually lasts less than a second. 
To prevent “blinks”, we want to show the popup only after 1 second.
If, by that 1 second, the operation has finished, there’s no need to show the popup.
