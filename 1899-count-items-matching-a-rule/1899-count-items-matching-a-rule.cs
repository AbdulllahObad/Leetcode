public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {

    //    int count = 0;
       int ruleIndex = ruleKey switch{
            "type" => 0,
            "color" => 1,
            _ => 2
        };
    //     foreach(var item in items){
    //         if(item[ruleIndex] == ruleValue) count++;
    //     }
    //     return count;      

    return items.Count(item => item[ruleIndex] == ruleValue);  
    }
}