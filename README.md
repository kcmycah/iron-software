# Old Phone Keypad Converter

This project provides a class and method that can be used to convert input from an old phone keypad into the corresponding output. The keypad consists of alphabetical letters, a backspace key, and a send button. Each button is associated with multiple letters, and pressing a button multiple times will cycle through the letters on it.

## Method

The main method provided in this project is `OldPhonePad()`, which takes an input string and returns the converted output string. The method signature is as follows:

```csharp
public static string OldPhonePad(string input)
```

### Input

The `input` parameter represents the input string from the old phone keypad. It may include a combination of numbers, backspaces, and the send button represented by the "#" symbol. The input is expected to be valid, with the send button always included at the end of the input.

### Output

The method returns the converted output string that corresponds to the input from the old phone keypad.

## Usage

To use the `OldPhonePad` method, follow these steps:

1. Include the relevant class file or reference the project in your C# solution.
2. Call the `OldPhonePad` method, passing the input string as an argument.
3. Capture the returned output string and use it as desired in your application.

Here's an example of how to use the `OldPhonePad` method:

```csharp
string input = "4433555 555666#";
string output = OldPhonePad(input);
Console.WriteLine("Output: " + output);
```

Output:
```
Output: HELLO
```

## Examples

Here are a few examples of using the `OldPhonePad` method:

1. `OldPhonePad("33#")` => Output: "E"
2. `OldPhonePad("227*#")` => Output: "B"
3. `OldPhonePad("4433555 555666#")` => Output: "HELLO"
4. `OldPhonePad("8 88777444666*664#")` => Output: "?????"

Please note that the last example includes a sequence of characters that cannot be converted into valid letters on the old phone keypad, resulting in a series of question marks in the output.

Feel free to explore the code and test different inputs to see how the conversion works.

Happy coding!
