# 🎙️ C# Console Voice Assistant (TTS & STT)

This project is a simple, console-based **Text-to-Speech (TTS)** and **Speech-to-Text (STT)** application developed using C# and the `.NET Framework`. It operates completely offline using the built-in Windows `System.Speech` library.

## ✨ Features

* **Text-to-Speech (TTS):** Reads aloud the text entered by the user in the console using the default Windows system voice.
* **Speech-to-Text (STT):** Listens to English words spoken into the microphone, prints them to the console in real-time, and displays the confidence score of the recognized speech.
* **Asynchronous Listening:** The application continuously listens in the background without freezing the console interface.

## 🛠️ Technologies Used

* **Language:** C#
* **Platform:** .NET Framework / Console Application
* **Library:** `System.Speech` (`System.Speech.Synthesis` and `System.Speech.Recognition`)

## ⚙️ Requirements and Setup

To run this project successfully, your system needs to meet the following requirements:

1. **Operating System:** Windows (The `System.Speech` library relies on native Windows APIs).
2. **Hardware:** A working microphone and speakers/headphones.
3. **Language Pack:** To recognize English words, your Windows system must have the **English (United States)** language and the **Speech Recognition** pack installed (Check *Settings > Time & Language > Language & region*).

### How to Run the Project

1. Clone this repository to your local machine:
   ```bash
   git clone [https://github.com/YOUR_USERNAME/console-voice-assistant.git](https://github.com/YOUR_USERNAME/console-voice-assistant.git)
