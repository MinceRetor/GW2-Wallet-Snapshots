# GW2 Wallet Snapshots

## Description
Application for creating snapshots of Guild Wars 2 wallet and showing the changes between them.

## Requirements
Windows

.NET 8 Runtime

[API key](https://wiki.guildwars2.com/wiki/API:API_key) for your account with "wallet" permission.

## Getting Started

1. Download and unpack GW2-Wallet-Snapshots.zip from [release page](https://github.com/MinceRetor/GW2-Wallet-Snapshots/releases).
2. Launch GW2-Wallet-Snapshots.exe. The first launch can take a few seconds as the application has to download icons for the currencies.
3. Go to Edit->Config
4. Paste your api key.
5. Click save and close the config window.

## Usage

### Create new snapshot
1. Click "Create Snapshot" button in the top-right corner of the main window.
2. (optional) Add description of the new snapshot.
3. Click big "Create Snapshot" button.

After creating a snapshot, you can notice that the "Create Snapshot" button becomes greyed out and a 5 minutes timer shows up on its left side. The reason is that guild wars 2 api cache results for requests for about 5 minutes, so even if you were to create a snapshot again, you will get the same result regardless if your wallet changed in-game.



## TODO
* Delete snapshots.
* Edit snapshot description.
* Select two snapshots and show changes between them.
