# Warehouse module: Example

This module is both a 'hello world' example and a start install, you can use for building a new module.

The module is build with [Bygdrift Warehouse](https://github.com/Bygdrift/Warehouse), that enables one to attach multiple modules within the same azure environment, that can collects and wash data from all kinds of services, in a cheap data lake and database.
By saving data to a MS SQL database, it is:
- easy to fetch data with Power BI, Excel and other systems
- easy to control who has access to what - actually, it can be controlled with AD so you don't have to handle credentials
- It's cheap

## Installation

All modules can be installed and facilitated with ARM templates (Azure Resource Management): [Use ARM templates to setup and maintain this module](https://github.com/Bygdrift/Warehouse.Modules.Example/blob/master/Deploy).

## License

[MIT License](https://github.com/Bygdrift/Warehouse.Modules.Example/blob/master/License.md)