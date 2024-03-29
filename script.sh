#!/bin/sh

# Pull changes from the remote repository
git pull

# Add all changes to the staging area
git add .

# Commit changes with the current date and time as the commit message
git commit -m "feat: some changes to the code base at $(date '+%Y-%m-%d %H:%M:%S')"

# Push changes to the remote repository
git push
