# Not Yet: Dialogue Plugin System - Example Project with Submodules

## ⚠🚨 This is for advanced users only who know how to use [git submodules](https://www.git-scm.com/book/en/v2/Git-Tools-Submodules)

## 👉 [Normal Example Project](https://github.com/NotYetGames/NotYetDlgSystemExample) 👈

Branch Unreal version: `5.3`

Example project for the [DlgSystem](https://github.com/NotYetGames/DlgSystem/) plugin.

**See the [Wiki](https://github.com/NotYetGames/DlgSystem/wiki) for the manual and tutorials.**

## Clone

**WARNING** if you don't clone like this the Plugin submodule won't be downloaded

```sh
git clone --recurse-submodules -j 2 -b 5.3 https://github.com/NotYetGames/NotYetDlgSystemExample-Submodules.git
```

---
**If you cloned without the submodules**:

```sh
cd NotYetDlgSystemExample-Submodules
git submodule update --init --recursive
```


## Git commands
```sh
# Update
./git-update.sh

# Was added with
git submodule add -b master git@github.com:NotYetGames/DlgSystem.git Plugins/DlgSystem
```
