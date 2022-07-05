#!/bin/bash
input=$1

while IFS= read -r line
do
  for element in "${line[@]}"
	do
	    if [[ $element == *"PackageReference Include"* ]]; then
  			text=(${element//\"/ })
  			echo ${text[2]}
  			dotnet add package ${text[2]}
		fi
	done
done < "$input"
