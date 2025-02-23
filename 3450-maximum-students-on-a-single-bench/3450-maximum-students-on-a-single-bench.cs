public class Solution {
    public int MaxStudentsOnBench(int[][] students) =>
        (students.Length == 0) ? 0 :
        students
        ?.GroupBy(student => student[1], student => student[0])
        ?.Select(student => student.Distinct().Count())
        ?.Max() ?? 0;
}