function isValidSubsequence(array, sequence) {
    let seqIdx = 0;
    for (const value of array) {
      if (value === sequence[seqIdx]) seqIdx++;
      if (seqIdx === sequence.length) return true;
    }
  
    return false;
}