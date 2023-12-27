using System.Collections.Generic;
using System.Speech.Recognition;
using VAICOM.Static;


namespace VAICOM
{
    namespace Database
    {

        public partial class AliasEditor
        {

            // offline keywords training
            public static void TrainingStartStop()
            {
                if (!State.trainerrunning)
                {
                    SpeechTrainer.Initialize();
                    SpeechTrainer.Start();
                }
                else
                {
                    SpeechTrainer.Stop();
                }
            }

            // trainer functions
            public static class SpeechTrainer
            {
                public static SpeechRecognizer trainer;

                public static void Start()
                {
                    try
                    {
                        UI.Playsound.Commandcomplete();

                        Log.Write("Offline keyword training initialized", Colors.System);
                        Log.Write("Ready for training.", Colors.Message);
                        State.trainerrunning = true;
                        trainer.SpeechRecognized += rec_SpeechRecognized;
                        trainer.SpeechRecognitionRejected += rec_SpeechRejected;
                        trainer.StateChanged += rec_StateChanged;

                    }
                    catch
                    {
                    }
                }

                public static void Stop()
                {
                    try
                    {
                        trainer.StateChanged -= rec_StateChanged;
                        trainer.SpeechRecognitionRejected -= rec_SpeechRejected;
                        trainer.SpeechRecognized -= rec_SpeechRecognized;

                        State.trainerrunning = false;

                        Log.Write("Keyword training finished.", Colors.Message);
                        Log.Write("----------------------------------", Colors.Message);
                        PushToTalk.PTT.PTT_Manage_Listen_VA(State.activeconfig.ReleaseHot);

                        UI.Playsound.Commandcomplete();
                    }
                    catch
                    {
                    }
                }

                // state changes
                public static void rec_StateChanged(object sender, StateChangedEventArgs e)
                {
                    string result = string.Format("State changed");
                }

                // recognized handler
                public static void rec_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
                {
                    string result = string.Format("Keyword recognized: " + e.Result.Text + " with confidence {0} %", (e.Result.Confidence * 100).ToString().Substring(0, 2));
                    Log.Write(result, Colors.Message);
                    UI.Playsound.Commandcomplete();
                }

                // unrecognized handler
                public static void rec_SpeechRejected(object sender, SpeechRecognitionRejectedEventArgs e)
                {
                    UI.Playsound.Error();
                }

                public static void Exit()
                {
                }

                public static void Terminate()
                {
                    trainer.Dispose();
                }

                // startup
                public static void Initialize()
                {
                    try
                    {
                        Log.Write("----------------------------------", Colors.Message);
                        Log.Write("Initializing Training Mode", Colors.Message);
                        State.trainerrunning = true;
                        Log.Reset();
                        trainer = new SpeechRecognizer();
                        trainer.UnloadAllGrammars();
                        trainer.MaxAlternates = 0;

                        Log.Write(trainer.RecognizerInfo.Description, Colors.System);

                        // add all aliases to new grammar
                        State.trainerchoices = new Choices();
                        foreach (KeyValuePair<string, Dictionary<string, string>> set in Aliases.categories)
                        {
                            foreach (KeyValuePair<string, string> listing in set.Value)
                            {
                                State.trainerchoices.Add(listing.Key.Replace("*", ""));
                            }
                        }

                        // load grammar and start
                        var grammarbuilder = new GrammarBuilder(State.trainerchoices);
                        var grammar = new Grammar(grammarbuilder);
                        trainer.LoadGrammar(grammar);
                        PushToTalk.PTT.PTT_Manage_Listen_VA(false);

                        Log.Write("VAICOM PRO command phrases loaded", Colors.System);
                        trainer.Enabled = true;

                        trainer.EmulateRecognize("Start listening");
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
