class Solution {
    public String[] uncommonFromSentences(String s1, String s2) {
        HashMap<String, Integer> s1hm = new HashMap<>();
        HashMap<String, Integer> s2hm = new HashMap<>();
        String[] s1Arr = s1.split(" ");
        String[] s2Arr = s2.split(" ");
        for(String s : s1Arr)
            s1hm.put(s, (s1hm.getOrDefault(s, 0) + 1));
        for(String s : s2Arr)
            s2hm.put(s, (s2hm.getOrDefault(s, 0) + 1));
        for(String s : s2Arr)
        {
            if(s1hm.containsKey(s))
            {
                s1hm.remove(s);
            }
        }
        for(String s : s1Arr)
        {
            if(s2hm.containsKey(s))
            {
                s2hm.remove(s);
            }
        }
        List<String> res = new ArrayList<>();
        for(Map.Entry<String, Integer> entry : s1hm.entrySet())
        {
            if(entry.getValue() == 1)
                res.add(entry.getKey());
        }
        for(Map.Entry<String, Integer> entry : s2hm.entrySet())
        {
            if(entry.getValue() == 1)
                res.add(entry.getKey());
        }
        
        return res.toArray(new String[res.size()]);
    }
}