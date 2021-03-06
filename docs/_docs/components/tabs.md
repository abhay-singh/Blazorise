---
title: "Tabs"
permalink: /docs/components/tabs/
excerpt: "Learn how to use tabs."
toc: true
toc_label: "Guide"
---

## Basics

There are two pieces to a tabbed interface: the tabs themselves, and the content for each tab. 

- `<Tabs>`
  - `<Tab>`
- `<TabsContent>`
  - `<TabPanel>`

The tabs are container for tab items. Each tab item contains a link to a tab panel. The `Name` of each tab item should match the `Name` of a tab panel.

The tab content container is used to hold tab panels. Each content pane also has a unique `Name`, which is targeted by a link in the tabstrip.

Put it all together, and we get this:

### Tab items

```html
<Tabs>
    <Tab Name="home" IsActive="true">Home</Tab>
    <Tab Name="profile">Profile</Tab>
    <Tab Name="messages">Messages</Tab>
    <Tab Name="settings">Settings</Tab>
</Tabs>
```

### Tabs content

```html
<TabsContent>
    <TabPanel Name="home" IsActive="true">
        ...
    </TabPanel>
    <TabPanel Name="profile">
        ...
    </TabPanel>
    <TabPanel Name="messages">
        ...
    </TabPanel>
    <TabPanel Name="settings">
        ...
    </TabPanel>
</TabsContent>
```

<iframe src="/examples/tabs/basic/" frameborder="0" scrolling="no" style="width:100%;height:625px;"></iframe>