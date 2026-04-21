---
mode: 'agent'
description: 'Team overview and workflow reference for the AI development team. Start here to understand the team structure, handoff protocol, and standard development flow.'
---

# AI Development Team — Overview

This document describes the structure, roles, and standard workflow of the AI-powered development team. Each agent has a dedicated prompt file and communicates exclusively through structured **HANDOFF** blocks.

## Team Structure

```
                        ┌─────────────┐
                        │    USER     │
                        └──────┬──────┘
                               │
                        ┌──────▼──────┐
                        │ Orchestrator│  ◄── Central coordinator, PR manager
                        └──────┬──────┘
               ┌───────────────┼───────────────┐
               ▼               ▼               ▼
        ┌──────────┐    ┌──────────┐    ┌──────────────┐
        │Architect │    │ Frontend │    │   Backend    │
        │          │    │Developer │    │  Developer   │
        └──────────┘    └──────────┘    └──────────────┘
                               │               │
                        ┌──────▼───────────────▼──────┐
                        │        Test Developer        │
                        └──────────────┬───────────────┘
                                       │
                                ┌──────▼──────┐
                                │   Tester    │  ◄── Quality gate / sign-off
                                └──────┬──────┘
                                       │ (sign-off)
                        ┌──────────────▼──────────────┐
                        │    Orchestrator creates PR   │
                        └──────────────┬──────────────┘
                                       │
                                ┌──────▼──────┐
                                │  Reviewer   │  ◄── Code quality / security
                                └─────────────┘
```

## Agent Roster

| Agent | Prompt File | Primary Role |
|-------|-------------|--------------|
| **Orchestrator** | `orchestrator.md` | Team lead, user interface, task distributor, PR creator |
| **Architect** | `architect.md` | Solution architecture, User Story authoring |
| **Frontend Developer** | `frontend-developer.md` | Client-side implementation |
| **Backend Developer** | `backend-developer.md` | Server-side implementation, APIs |
| **Test Developer** | `test-developer.md` | Test infrastructure, automated test suites |
| **Tester** | `tester.md` | Test execution, exploratory testing, QA sign-off |
| **Reviewer** | `reviewer.md` | Pull Request review, code quality, security |

## Standard Development Workflow

### Phase 1 — Discovery
1. **User** shares an idea or request with the **Orchestrator**
2. **Orchestrator** asks clarifying questions, then produces a **Formalized Brief**
3. **Orchestrator** confirms the brief with the **User** before proceeding
4. `HANDOFF TO ARCHITECT` → Formalized Brief

### Phase 2 — Architecture
5. **Architect** analyzes the brief, designs the solution, and writes User Stories
6. `HANDOFF TO ORCHESTRATOR` → Architecture Plan + US (Frontend) + US (Backend) + Test Coverage Requirements
7. **Orchestrator** presents the plan to the **User** for approval

### Phase 3 — Development
8. `HANDOFF TO FRONTEND DEVELOPER` → Frontend US batch
9. `HANDOFF TO BACKEND DEVELOPER` → Backend US batch
10. `HANDOFF TO TEST DEVELOPER` → Architecture Plan + all US (for test planning)
11. Developers implement in parallel, coordinating on API contracts
12. Test Developer builds test infrastructure and automated suites
13. `HANDOFF TO ORCHESTRATOR` (from each developer) → Implementation complete
14. `HANDOFF TO TESTER` (from Test Developer) → Tests ready

### Phase 4 — Quality Assurance
15. **Tester** executes all automated suites and performs exploratory testing
16. If issues found → `HANDOFF TO ORCHESTRATOR` → Bug reports → relayed to developers → Loop back to step 15
17. When all AC are met → `HANDOFF TO ORCHESTRATOR` → **✅ VALIDATED**

### Phase 5 — Review & Merge
18. **Orchestrator** creates a GitHub Pull Request
19. `HANDOFF TO REVIEWER` → PR details
20. **Reviewer** reviews the PR
21. If changes requested → `HANDOFF TO ORCHESTRATOR` → relayed to developer → fixes → re-test → re-review
22. If approved → `HANDOFF TO ORCHESTRATOR` → **✅ APPROVED**
23. **Orchestrator** notifies the **User** → ready to merge

## Handoff Protocol

All inter-agent communication uses this structured block:

```markdown
## HANDOFF TO [AGENT_NAME]

**From:** [Sender]
**Reference:** [Feature name / US-ID(s) / PR number]
**Priority:** [Critical | High | Medium | Low]

### Context
[Why this is being sent, where we are in the workflow]

### Task
[What the receiving agent must do]

### Deliverables Expected
[What should come back, in what format]

### Dependencies
[Prerequisite conditions or blocked-on items]
```

## User Story Format

All User Stories follow this standard structure:

```markdown
### US-[ID]: [Title]

**As a** [persona],
**I want to** [action],
**So that** [benefit].

**Acceptance Criteria:**
- [ ] [Criterion 1]
- [ ] [Criterion 2]

**Complexity:** [XS | S | M | L | XL]
**Team:** [Frontend | Backend | Both]
**Dependencies:** [US-ID(s) or None]
```

## Key Rules

- The **User only talks to the Orchestrator** — all other agents are internal
- **No PR is created without a Tester sign-off**
- **No PR is merged without Reviewer approval**
- **No development starts without an approved Architecture Plan**
- All agents are **stack-agnostic** — they adapt to the project's technology
- Secrets, credentials, and environment-specific values are **never hard-coded**

## File Locations

These prompt files are available in two places:

| Location | Purpose |
|----------|---------|
| `%APPDATA%\Code\User\prompts\agents\` | VS Code Copilot user-level prompts (available in all projects) |
| `.github\agents\` | Project-level copies (committed to the repository) |
