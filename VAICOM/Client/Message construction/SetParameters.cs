
namespace VAICOM
{

    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {

                public static void SetParameters()
                {

                    string selector = State.currentcommand.dcsid;

                    switch (selector)
                    {


                        case "wMsgLeaderMakeRecon": // make recon
                            State.currentmessage.parameters.Add(State.currentcommand.parameters);
                            break;

                        case "wMsgLeaderInbound": // ATC inbound 
                            State.currentcommand.point = State.currentstate.availablerecipients["Player"][0].pos;
                            State.currentmessage.parameters.Add(State.currentcommand.point);
                            break;

                        case "wMsgLeaderCheckIn":// jtac check-in
                            State.currentmessage.parameters.Add(State.currentcommand.parameters);
                            break;

                        case "wMsgLeader9LineReadback": // jtac readback
                            State.currentmessage.parameters.Add(State.currentcommand.readback);
                            break;

                        case "wMsgLeaderSpecialCommand": // crew special
                            {
                                int commandkey = State.currentcommand.uniqueid;
                                switch (commandkey)
                                {
                                    case 18002:
                                        State.currentmessage.parameters.Add(State.currentcommand.type);
                                        break;

                                    case 18003:
                                        State.currentmessage.parameters.Add(State.currentcommand.type);
                                        break;

                                    case 18004:
                                        State.currentmessage.parameters.Add(State.currentcommand.type);
                                        State.currentmessage.parameters.Add(State.currentcommand.device);
                                        break;

                                    case 18005:
                                        State.currentmessage.parameters.Add(State.currentcommand.type);
                                        State.currentmessage.parameters.Add(State.currentcommand.device);
                                        break;

                                    case 18006:
                                        State.currentmessage.parameters.Add(State.currentcommand.type);
                                        State.currentmessage.parameters.Add(State.currentcommand.power_source);
                                        break;

                                    case 18007:
                                        State.currentmessage.parameters.Add(State.currentcommand.type);
                                        State.currentmessage.parameters.Add(State.currentcommand.power_source);
                                        break;

                                    case 18008:
                                        State.currentmessage.parameters.Add(State.currentcommand.parametername);
                                        State.currentmessage.parameters.Add(State.currentcommand.value);
                                        break;

                                    case 18009:
                                        State.currentmessage.parameters.Add(State.currentcommand.parametername);
                                        State.currentmessage.parameters.Add(State.currentcommand.value);
                                        break;

                                    default:
                                        break;
                                }

                            }
                            break;

                        case "wMsgLeaderRequestRefueling": 
                            State.currentmessage.parameters.Add(State.currentcommand.volume);
                            break;

                        case "wMsgLeaderGroundToggleElecPower": 
                            State.currentmessage.parameters.Add(State.currentcommand.on);
                            break;

                        case "wMsgLeaderGroundToggleWheelChocks":
                            State.currentmessage.parameters.Add(State.currentcommand.on);
                            break;

                        case "wMsgLeaderGroundToggleCanopy":
                            State.currentmessage.parameters.Add(State.currentcommand.close); //.on
                            break;

                        case "wMsgLeaderGroundToggleAir": 
                            State.currentmessage.parameters.Add(State.currentcommand.on);
                            break;

                        case "wMsgLeaderGroundApplyAir": 
                            State.currentmessage.parameters.Add(State.currentcommand.on);
                            break;

                        case "wMsgLeaderGroundGestureSalut": 
                            State.currentmessage.parameters.Add(State.currentcommand.on);
                            break;

                        case "wMsgLeaderGroundRequestLaunch": 
                            State.currentmessage.parameters.Add(State.currentcommand.on);
                            break;

                        default:
                            break;
                    }
                }

            }
        }
    }
}



