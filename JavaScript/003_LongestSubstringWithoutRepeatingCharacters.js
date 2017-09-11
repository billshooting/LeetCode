'use strict';
/**
 * @param {string} s
 * @return {number}
 */
/* 两个游标 */
var lengthOfLongestSubstring = function(s) {
    if(s.length === 0) return 0;
    let set = new Set();
    let i = 0, j = 1, maxLength = 0;
    set.add(s[0]);
    for(; j < s.length; j++)
    {
        if(set.has(s[j]))
        {
            maxLength = Math.max(j - i, maxLength);
            while(s[i] !== s[j])
            {
                set.delete(s[i]);
                i++;
            }
            i++;
        }
        else set.add(s[j]);
    }
    return Math.max(j - i, maxLength);
};
lengthOfLongestSubstring("abcabcbb");