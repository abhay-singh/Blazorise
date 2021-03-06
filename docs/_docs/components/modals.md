---
title: "Modals"
permalink: /docs/components/modals/
excerpt: "Learn how to use modals."
toc: true
toc_label: "Guide"
---

## Basics

The modal structure is very simple:

- `<Modal>` the main container
  - `<ModalBackdrop>` a transparent overlay that can act as a click target to close the modal
  - `<ModalContent>` a horizontally and vertically centered container, in which you can include _any_ content
    - `<ModalHeader>` top part of the modal, usually contains a title and close button
      - `<CloseButton>` a simple close button located in the top right corner
    - `<ModalBody>` main part of the modal, holds the input fields, images, etc.
    - `<ModalFooter>` bottom part of the modal, usually contains the action buttons


### Usage

Place the modal markup somewhere at root of you component layout.

```html
<SimpleButton Clicked="@ShowModal">Show Modal</SimpleButton>

<Modal ref="modalRef">
    <ModalBackdrop />
    <ModalContent IsCentered="true">
        <ModalHeader Title="Employee edit">
            <CloseButton Clicked="@HideModal" />
        </ModalHeader>
        <ModalBody>
            <Field>
                <FieldLabel>Name</FieldLabel>
                <TextEdit Placeholder="Enter name..." />
            </Field>
            <Field>
                <FieldLabel>Surname</FieldLabel>
                <TextEdit Placeholder="Enter surname..." />
            </Field>
        </ModalBody>
        <ModalFooter>
            <SimpleButton Color="Color.Secondary" Clicked="@HideModal">Close</SimpleButton>
            <SimpleButton Color="Color.Primary" Clicked="@HideModal">Save Changes</SimpleButton>
        </ModalFooter>
    </ModalContent>
</Modal>
```

To work with the modal you must use the reference to the `Modal` component.

```cs
@functions{
    // reference to the modal component
    private Modal modalRef;

    private void ShowModal()
    {
        modalRef.Show();
    }

    private void HideModal()
    {
        modalRef.Hide();
    }
}
```