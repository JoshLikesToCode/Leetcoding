#include <string.h>

int countConsistentStrings(char * allowed, char ** words, int wordsSize){
    
    int count = 0;
    for(int i = 0; i < wordsSize; i++)
    {
        char *word = words[i];
        if(word[strspn(word, allowed)] == '\0')
            count++;
    }
    return count;
}