class Solution {
    public boolean checkInclusion(String s1, String s2) {
        int start = 0;
        int matches = 0;
        int s1Length = s1.length();
        int s2Length = s2.length();
        Map<Character, Integer> hm = new HashMap<>();
        
        for(Character c : s1.toCharArray())
            hm.put(c, (hm.getOrDefault(c, 0) + 1));
        
        for(int i = 0; i < s2Length; i++)
        {
            Character rightChar = s2.charAt(i);
            if(hm.containsKey(rightChar))
            {
                hm.put(rightChar, hm.get(rightChar) - 1);
                if(hm.get(rightChar) == 0)
                    matches++;
            }
            
            if(matches == hm.size())
                return true;
            
            if(i >= s1Length - 1)
            {
                Character leftChar = s2.charAt(start++);
                if(hm.containsKey(leftChar))
                {
                    if(hm.get(leftChar) == 0)
                        matches--;
                    hm.put(leftChar, hm.getOrDefault(leftChar, 0) + 1);
                }
            }
        }
        return false;
    }
}