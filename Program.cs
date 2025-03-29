using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
using System.Speech.Synthesis;

namespace CyberSecChatbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ASCII Art 
            Console.WriteLine("       ");
            Console.WriteLine(" ██████ ██    ██ ██████  ███████ ██████  ██████   ██████  ██      ██  ██████ ███████   \r\n██       ██  ██  ██   ██ ██      ██   ██ ██   ██ ██    ██ ██      ██ ██      ██        \r\n██        ████   ██████  █████   ██████  ██████  ██    ██ ██      ██ ██      █████     \r\n██         ██    ██   ██ ██      ██   ██ ██      ██    ██ ██      ██ ██      ██        \r\n ██████    ██    ██████  ███████ ██   ██ ██       ██████  ███████ ██  ██████ ███████   \r\n                                                                                       \r\n                                                                                       \r\n               ██████ ██   ██  █████  ████████ ██████   ██████  ████████               \r\n              ██      ██   ██ ██   ██    ██    ██   ██ ██    ██    ██                  \r\n    █████     ██      ███████ ███████    ██    ██████  ██    ██    ██        █████     \r\n              ██      ██   ██ ██   ██    ██    ██   ██ ██    ██    ██                  \r\n               ██████ ██   ██ ██   ██    ██    ██████   ██████     ██                  \r\n                                                                                       \r\n                                                                                       ");

            // configure Speech Synthesizer
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;  // Set Volume (0-100)
            synth.Rate = 0;      // Set Speed (-10 to 10)
            synth.SelectVoiceByHints(VoiceGender.Female); // Choose Female voice

            // Greeting
            string greeting = "Hello, I am a Cybersecurity Awareness Assistant. What is your name?";
            Console.WriteLine(greeting);
            synth.Speak(greeting);


            // Get user's name
            string userName = Console.ReadLine();

            // create a greeting with the user's name
            string personalizedGreeting = $"Hello {userName}, how can I assist you with cybersecurity today? Feel free to ask me anything!";
            Console.WriteLine(personalizedGreeting);
            synth.Speak(personalizedGreeting);

        
    


while (true)
{
    Console.WriteLine("What would you like to know about cybersecurity? (Type 'exit' to quit)");
    string userQuestion = Console.ReadLine().ToLower();

    if (userQuestion == "exit")
    {
        break;  // Exit the while loop to end the program
    }

    // Answering questions based on input
    string response = GetResponse(userQuestion);
    Console.WriteLine(response);
    synth.Speak(response);
}
//exit goodbye message
Console.WriteLine("Goodbye! Stay safe online.");
synth.Speak("Goodbye! Stay safe online."); 
        }

        static string GetResponse(string userQuestion)
{
    // Default response to invalid input
    string defaultResponse = "I'm sorry, I don't understand that. Could you please rephrase your question?";

    // Responses 
    if (userQuestion.Contains("password") || userQuestion.Contains("password safety"))
    {
        return "It's important to use strong, unique passwords for each of your accounts. Use a mix of letters, numbers, and special characters. Avoid using the same password across multiple sites.";
    }
    else if (userQuestion.Contains("phishing"))
    {
        return "Phishing is a fraudulent attempt to obtain sensitive information by pretending to be a trustworthy entity. Be cautious about unsolicited emails or messages that ask for personal details or contain suspicious links.";
    }
    else if (userQuestion.Contains("safe browsing") || userQuestion.Contains("search safely"))
    {
        return "To browse safely, avoid clicking on suspicious links, use a reputable antivirus program, and ensure your browser is updated to the latest version. Always check if a website's URL starts with 'https://' for secure connections.";
    }
    else if (userQuestion.Contains("malware"))
    {
        return "Malware is any software designed to harm your computer or steal your data. To protect yourself, install reputable antivirus software, keep your system updated, and be cautious when downloading files or clicking on links.";
    }
    else if (userQuestion.Contains("social engineering"))
    {
        return "Social engineering is when attackers manipulate people into divulging confidential information. Always verify the identity of people who request sensitive information, and don't fall for tricks like urgent messages from 'official' sources.";
    }
    else if (userQuestion.Contains("financial identity loss") || userQuestion.Contains("fraud"))
    {
        return "Financial identity theft occurs when someone uses your personal information to steal money or commit fraud. Protect your financial identity by monitoring your bank statements, using two-factor authentication, and avoiding sharing sensitive financial details online.";
    }
    else if (userQuestion.Contains("psychological harm") || userQuestion.Contains("mental harm") || userQuestion.Contains("cyberbullying"))
    {
        return "Psychological harm from online threats such as cyberbullying or online harassment can be very damaging. It's important to reach out for help if you're affected, whether from a counselor or a support group, and report any harmful behavior.";
    }
    else if (userQuestion.Contains("who are you") || userQuestion.Contains("what is your purpose"))
    {
        return "I am a Cybersecurity Awareness Assistant, here to help you learn more about staying safe online. Feel free to ask me about cybersecurity topics!";
    }
    else if (userQuestion.Contains("what can i ask you about") || userQuestion.Contains("what can you help with") || userQuestion.Contains("help"))
    {
        return "You can ask me about topics like password safety, phishing, safe browsing, malware, social engineering, and much more related to cybersecurity. I'm here to help!";
    }
    else
    {
        return defaultResponse;
    }
}
    }
}
        
    
