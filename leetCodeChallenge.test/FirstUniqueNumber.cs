using System;
using System.Collections.Generic;

namespace letmecodeChallenge.test
{
    public class FirstUniqueNumber
    {

        public int firstUniqChar(string s) {
            var store = new Dictionary<char,(int,int)>(); //data struct that maps letter:(freq of occurance, first index seen)
            int res = s.Length;//store lowest index of first unique
            for(int i=0; i<res; i++){
                var currLetter = s[i]; //current letter
                var currKey = (store.ContainsKey(currLetter))?(store[currLetter].Item1+1,store[currLetter].Item2):(1,i);
                store[currLetter]=currKey;
            }
            foreach(var currKey in store.Values){
                if(currKey.Item1==1){//Check for only single occurance
                    res = Math.Min(res,currKey.Item2);//update res
                }
            }
            return (res==s.Length)?-1:res;//-1 or update val
        }


    }
}
