read m
if [ $m -lt 100 ]; then
    echo 00
elif [ $m -le 5000 ]; then
    printf "%02d\n" $(($m/100))
elif [ $m -le 30000 ]; then
    echo $(($m/1000+50))
elif [ $m -le 70000 ]; then
    echo $((($m/1000-30)/5+80))
else
    echo 89
fi