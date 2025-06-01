public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {

        List<bool> res = new List<bool>();
        
        foreach(int candy in candies){
            int luckyKid =  candy + extraCandies;
            bool Isgreatest = true;
            foreach(int c in candies){
                if (c > luckyKid){
                    Isgreatest = false;
                }
            }
              res.Add(Isgreatest);
        }
        return res;     
    }
}