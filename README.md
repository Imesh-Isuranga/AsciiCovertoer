
## ASCII CNC Engraving Code Generator

Seamlessly merge syntax codes and ASCII text to generate precise unique code sequences. Enjoy real-time syntax visualization, toggle code comments, and save outputs for seamless CNC machining.For this I have used c# language.





## Set Up Development Environment:

Make sure you have a development environment for C# programming installed. You can use Visual Studio or Visual Studio Code with the appropriate extensions.
Create a New Project:

## Implement Functionality:

Write the C# code to implement the described functionalities.
- For TextBox 1: Capture and display the syntax code entered in real-time.
- For TextBox 2: Allow users to enter the text to be engraved.
- For the Generate Code button: Concatenate syntax codes and ASCII text to generate G-code sequences.
- For the code comment checkbox: Toggle code comments in the output.
- For the Save to Text File button: Save the generated G-code output to a text file.

## Run the Application:

Build and run your application from the development environment.
The application's UI will be displayed, allowing you to interact with its various components.


## Input and Output:

- Enter the required syntax code in TextBox 1.
- Input the desired text to be engraved in TextBox 2.
- Click the Generate Code button to create the G-code sequences.
- Toggle the code comment checkbox based on machine compatibility.
- Click the Save to Text File button to save the G-code output.



## Run Locally

Clone the project

```
private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                    string filePath = "E:\\My New Creation\\final.txt";
                    string textToSave = txtThree.Text;

                    File.WriteAllText(filePath, textToSave);

                    MessageBox.Show("File saved successfully.");
             
            }
        }
```
You can change filePath and textTo save as u like.



## Screenshots


![App Screenshot](https://raw.githubusercontent.com/Imesh-Isuranga/AsciiCovertoer/main/screenShot.png)
