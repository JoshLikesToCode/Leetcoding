class MyCalendar {
    List<int[]> list;
    
    public MyCalendar() {
        this.list = new ArrayList<>();
    }
    
    public boolean book(int start, int end) {
        for(int[] times : list)
        {
            if(times[0] < end && times[1] > start)
                return false;
        }
        int[] time = new int[]{start, end};
        list.add(time);
        return true;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * boolean param_1 = obj.book(start,end);
 */