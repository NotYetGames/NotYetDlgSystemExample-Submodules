# Not Yet: Dialogue Plugin System - Example Project with Submodules

## ⚠🚨 This is for advanced users only who know how to use [git submodules](https://www.git-scm.com/book/en/v2/Git-Tools-Submodules)

## 👉 [Normal Example Project](https://gitlab.com/NotYetGames/NotYetDlgSystemExample) 👈


Branch Unreal version: `4.25`


Github Mirror: [HERE](https://github.com/NotYetGames/NotYetDlgSystemExample-Submodules)

Example project for the [DlgSystem](https://gitlab.com/NotYetGames/DlgSystem/) plugin.

**See the [Wiki](https://gitlab.com/NotYetGames/DlgSystem/wikis/home) for the manual and tutorials.**

## Clone

**WARNING** if you don't clone like this the Plugin submodule won't be downloaded

```sh
git clone --recurse-submodules -j 2 -b 4.25 https://gitlab.com/NotYetGames/NotYetDlgSystemExample-Submodules.git
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
git submodule add -b 4.25 https://gitlab.com/NotYetGames/DlgSystem.git Plugins/DlgSystem
```
