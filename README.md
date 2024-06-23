# ConditionalBreakpointAndTracepoint
<hr/>
#Add a Conditional Breakpoint <br/>
<p>
  <img src="https://github.com/kodpencerem/ConditionalBreakpointAndTracepoint/assets/35402914/240b90e2-9786-452d-9975-fa7613070a34" alt=""/>
</p>
<br/>
Set a Breakpoint: Click in the left margin next to the line if (result == 10) to set a breakpoint.<br/>
<p>
  <img src="https://github.com/kodpencerem/ConditionalBreakpointAndTracepoint/assets/35402914/14a4007d-55a6-4a3c-be6b-6a863d58be08" alt=""/>  
</p>
<br/>
Right-Click the Breakpoint: Right-click the red dot that appears.<br/>
Set Condition: Select “Conditions…” from the context menu.<br/>
Enter Condition: In the dialog that appears, enter result == 10. The breakpoint will only be hit when this condition is true.<br/>
<p>
  <img src="https://github.com/kodpencerem/ConditionalBreakpointAndTracepoint/assets/35402914/d192a41f-fc96-4339-b64e-7acb87cb9513" alt=""/>  
</p>
<br/>
<hr/>
#Add a Tracepoint<br/>
Set a Breakpoint: Click in the left margin next to the line Console.WriteLine($"Iteration: {i}, Result: {result}"); to set a breakpoint.<br/>
Right-Click the Breakpoint: Right-click the red dot.<br/>
<p>
  <img src="https://github.com/kodpencerem/ConditionalBreakpointAndTracepoint/assets/35402914/461b440a-cdeb-4f21-a074-29b81179bb42" alt=""/> 
</p>
<br/>
When Hit…: Select “When Hit…” from the context menu.<br/>
Specify Message: In the dialog that appears, enter Iteration: {i}, Result: {result} in the “Output window” text box. This message will be printed in the Output window each time the tracepoint is hit.<br/>
<p>
  <img src="https://github.com/kodpencerem/ConditionalBreakpointAndTracepoint/assets/35402914/f704e66c-4183-4c69-9191-713e14a9a972" alt=""/> 
</p>
<br/>
<hr/>
#Explanation<br/>
Conditional Breakpoint: The breakpoint on if (result == 10) will only be triggered when the result variable equals 10. This helps you focus on specific conditions without stopping at every iteration.<br/>
Tracepoint: The tracepoint on Console.WriteLine($"Iteration: {i}, Result: {result}"); will print the iteration and result values to the Output window each time it is hit, allowing you to monitor the values without pausing the execution.<br/>
By following these steps, you can effectively use conditional breakpoints and tracepoints to debug and monitor your application. This example provides a more detailed scenario with a class and methods to illustrate their usage.<br/>

<hr/>
For more examples and information;<br/>
1.	<p><a href="https://learn.microsoft.com/en-us/visualstudio/debugger/using-tracepoints?view=vs-2022" target="_blank">Log info with tracepoints - Visual Studio (Windows) | Microsoft Learn</a></p><br/>
2.	c# - What are tracepoints used for? - Stack Overflow<br/>
3.	Visual Studio Debugger Tips and Tricks: Tracepoints (mariuszwojcik.com)<br/>
4.	Visual Studio - How to use conditional breakpoints | makolyte<br/>



