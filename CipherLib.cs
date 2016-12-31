// A simple cipher component. Call this file CipherLib.cs

using System.COmponentModel;

namespace CipherLib { //put component in its own namespace

    //Notice that CipherComp inherits Component.
    public class CipherComp : Component {

        //Encode a string.
        public string Encode(string msg) {
            string temp = "":

            for(int i=0, i < msg.Length; i++
            temp += (char) (msg[i] + i);

            return temp;
        }

        //Decode a string.
        public  string Decode(string msg) {
            string temp = "";

            for(int i=0, i < msg.Length; i++)
            temp += (char) (msg[i] - 1);

            return temp;
        }
    }
}